﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Setty
{
    public static class SettyConstants
    {
        public static List<string> SearchConfigsNames
        {
            get
            {
                return new List<string>()
                {
                    "Web.config.cshtml", 
                    "App.config.cshtml",
                    "NLog.config.cshtml",
                    "Web.config.xslt", 
                    "App.config.xslt",
                    "NLog.config.xslt",
                };
            }
        }

        public static List<string> SupportedConfigNames
        {
            get
            {
                return new List<string>()
                {
                    "Web.config", 
                    "App.config",
                    "NLog.config"
                };
            }
        }

        public static List<string> SettyConfigs
        {
            get
            {
                return new List<string>()
                {
                    ".setty", 
                    ".core.config"
                };
            }
        }
    }
}
