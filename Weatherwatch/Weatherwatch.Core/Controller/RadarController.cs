﻿using System.Collections.Generic;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class RadarController
    {
        private readonly Storage _storage;

        public RadarController()
        {
            _storage = Storage.GetInstance();
        }

        public List<Radar> GetRadars()
        {
            return _storage.GetRadars();
        }

        public Radar GetRadar(string name)
        {
            return _storage.GetRadar(name);
        }
    }
}