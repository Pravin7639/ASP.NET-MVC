using System.Web.Mvc;

namespace _05_AreaAndFilters.Areas.User
{
    public class UserAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "User";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "User_default",
                "User/{controller}/{action}/{id}",
                new { Controller="Home" , action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}