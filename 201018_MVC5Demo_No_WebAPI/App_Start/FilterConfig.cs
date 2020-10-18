using System.Web;
using System.Web.Mvc;

namespace _201018_MVC5Demo_No_WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
