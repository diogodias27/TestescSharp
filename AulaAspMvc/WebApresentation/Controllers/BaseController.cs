using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApresentation.Helpers;

namespace WebApresentation.Controllers
{
    public class BaseController : Controller
    {

        public void AddAlert(string alertStyle, string message, bool dismissable)
        {
            var alerts = TempData.ContainsKey(Alert.TempDataKey) ?
                (List<Alert>)TempData[Alert.TempDataKey] : new List<Alert>();

            alerts.Add(new Alert
            {
                AlertStyle = alertStyle,
                Dissmissable = dismissable,
                Message = message
            });
            TempData[Alert.TempDataKey] = alerts;
        }

        public void Success(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Success, message, dismissable);
        }
        public void Information(string message , bool dismissable = false)
        {
            AddAlert(AlertStyles.Information, message, dismissable);
        }
        public void Warning(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Warning, message, dismissable);
        }
        public void Danger (string message , bool dismissable = false)
        {
            AddAlert(AlertStyles.Danger, message, dismissable);
        }

    }
}


//aula 6 ok