using System.Web.Mvc;

namespace GMS.Web.Admin.Areas.PersonManage
{
    public class PersonManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PersonManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PersonManage_default",
                "PersonManage/{controller}/{action}/{id}",
                new { action = "Default", id = UrlParameter.Optional }
            );
        }
    }
}
