﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EeveexModManager.Interfaces;

namespace EeveexModManager.Classes.JsonClasses.API
{
    public class Api_ModInfo
    {
        public ulong id { get; set; }
        public int game_id { get; set; }
        public string name { get; set; }
        public int category_id { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public string version { get; set; }
        public string author { get; set; }
        public string mod_page_uri { get; set; }
    }
}
