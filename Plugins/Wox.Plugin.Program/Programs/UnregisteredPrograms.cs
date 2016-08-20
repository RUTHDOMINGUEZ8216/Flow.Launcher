﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Wox.Plugin.Program.ProgramSources
{
    [Serializable]
    public class UnregisteredPrograms : Win32
    {
        public string Location { get; set; } = "";

        public override List<Program> LoadPrograms()
        {
            if (Directory.Exists(Location) && MaxDepth >= -1)
            {
                var apps = new List<Program>();
                GetAppFromDirectory(apps, Location, MaxDepth);
                return apps;
            }
            else
            {
                return new List<Program>();
            }
        }
    }
}