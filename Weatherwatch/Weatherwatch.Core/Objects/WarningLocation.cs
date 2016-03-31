using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Weatherwatch.Core.Objects
{
    public class WarningLocation
    {
        public Warning[] Warnings { get; set; }
        public string Url { get; set; }
        public string Location { get; set; }

        public WarningLocation(string location, string url)
        {
            Url = url;
            Location = location;
        }

        public Warning[] GetWarnings()
        {
            return Warnings;
        }

        public void LoadWarnings()
        {
            List<Warning> list = new List<Warning>();

            try
            {
                // download the JSON string of the weather warning API
                using (WebClient client = new WebClient())
                {
                    // set the url to the weather warning API
                    string warningApi = client.DownloadString(Url);

                    try
                    {
                        // get the individual alerts/warnings from the JSON string.
                        RootObject objects = JsonConvert.DeserializeObject<RootObject>(warningApi);
                        foreach (object t in objects.alerts)
                        {
                            // get the alert/warning messages and add them to the alertBoxList.
                            list.Add(WarningMessages(t.ToString()));
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Could not create list of alerts.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Unable to receive alerts list from Weather Underground.");
            }

            Warnings = list.ToArray();
        }

        public Warning WarningMessages(string warningJson)
        {
            // Get the warning type of the warning string
            int startString = warningJson.LastIndexOf("\"wtype_meteoalarm_name\": ") + 26;
            int endString = warningJson.IndexOf("\"level_meteoalarm") - 6;
            int lengthString = endString - startString;
            string warningType = warningJson.Substring(startString, lengthString);

            // Get the warning color-level of the warning string
            startString = warningJson.LastIndexOf("\"level_meteoalarm_name\": ") + 26;
            endString = warningJson.LastIndexOf("\"level_meteoalarm") - 6;
            lengthString = endString - startString;
            string warningLevel = warningJson.Substring(startString, lengthString);

            // Get the warning start of the warning string
            startString = warningJson.LastIndexOf("\"date\": ") + 9;
            endString = warningJson.LastIndexOf("\"date_epoch") - 6;
            lengthString = endString - startString;
            string warningStart = warningJson.Substring(startString, lengthString);

            // Get the warning end of the warning string
            startString = warningJson.LastIndexOf("\"expires\": ") + 12;
            endString = warningJson.LastIndexOf("\"expires_epoch") - 6;
            lengthString = endString - startString;
            string warningEnd = warningJson.Substring(startString, lengthString);

            return new Warning(Location,warningType,warningLevel, warningStart, warningEnd);
        }
    }
}
