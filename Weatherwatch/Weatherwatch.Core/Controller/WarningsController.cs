using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class WarningsController
    {
        private readonly Storage _storage;
        public static string warningType { get; private set; }
        public static string warningLevel { get; private set; }
        public static string warningStart { get; private set; }
        public static string warningEnd { get; private set; }

        public WarningsController()
        {
            _storage = Storage.GetInstance();
        }

        public Warning GetWarning(string location)
        {
            return _storage.GetWarning(location);
        }

        public List<Warning> GetWarnings()
        {
            return _storage.GetWarnings();
        }

        public string[] GetRadarNames()
        {
            return GetWarnings().Select(warning => warning.Location).ToArray();
        }


        public static void getWarnings(string apiUrl)
        {

            try
            {
                // set the url to the weather warning API
                string warningAPI;

                // download the JSON string of the weather warning API
                using (WebClient client = new WebClient())
                {
                    warningAPI = client.DownloadString(apiUrl);
                }

                try
                {
                    // get the individual alerts/warnings from the JSON string.
                    List<RootObject> warnings = new List<RootObject>();
                    RootObject objects = JsonConvert.DeserializeObject<RootObject>(warningAPI);
                    warnings.Add(objects);
                    for (int index = 0; index < objects.alerts.Count; index++)
                    {
                        // get the alert/warning messages and add them to the alertBoxList.
                        warningMessages(objects.alerts[index].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Could not create list of alerts.");
                }
            }
            catch
            {
                Console.WriteLine("Unable to receive alerts list from Weather Underground.");
            }
        }

        public static void warningMessages(string warning)
        {
            // Get the warning type of the warning string
            int startString = warning.LastIndexOf("\"wtype_meteoalarm_name\": ") + 26;
            int endString = warning.IndexOf("\"level_meteoalarm") - 6;
            int lengthString = endString - startString;
            warningType = warning.Substring(startString, lengthString);

            // Get the warning color-level of the warning string
            startString = warning.LastIndexOf("\"level_meteoalarm_name\": ") + 26;
            endString = warning.LastIndexOf("\"level_meteoalarm") - 6;
            lengthString = endString - startString;
            warningLevel = warning.Substring(startString, lengthString);

            // Get the warning start of the warning string
            startString = warning.LastIndexOf("\"date\": ") + 9;
            endString = warning.LastIndexOf("\"date_epoch") - 6;
            lengthString = endString - startString;
            warningStart = warning.Substring(startString, lengthString);

            // Get the warning end of the warning string
            startString = warning.LastIndexOf("\"expires\": ") + 12;
            endString = warning.LastIndexOf("\"expires_epoch") - 6;
            lengthString = endString - startString;
            warningEnd = warning.Substring(startString, lengthString);
        }
    }
}
