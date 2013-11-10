using System.Web;
using System.Web.Mvc;

namespace NLayerApp.ContactManager45.Web.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}