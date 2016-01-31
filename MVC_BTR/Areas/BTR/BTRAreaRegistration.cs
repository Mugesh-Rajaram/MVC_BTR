using System.Web.Mvc;

namespace MVC_BTR.Areas.BTR
{
    public class BTRAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BTR";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "BTR_default",
                "BTR/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MVC_BTR.Areas.BTR.Controllers" }
            );
        }
    }
}
