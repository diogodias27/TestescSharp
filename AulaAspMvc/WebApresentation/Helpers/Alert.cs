using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApresentation.Helpers
{
    public class Alert
    {
        public const string TempDataKey = "TempDataAlerts";
        public string AlertStyle { get; set; }
        public string Message { get; set; }
        public bool Dissmissable { get; set; }


    }

    public static class AlertStyles
    {
        public const string Success = "Success";
        public const string Information = "Information";
        public const string Warning = "Warning";
        public const string Danger = "Danger";
    }
}