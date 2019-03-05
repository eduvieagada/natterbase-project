using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NatterbaseProject.App_Start
{
    public class AppConfig
    {
        public static string AudienceId { get => ConfigurationManager.AppSettings.Get("as:AudienceId"); }
        public static string AudienceSecret { get => ConfigurationManager.AppSettings.Get("as:AudienceSecret"); }
    }
}