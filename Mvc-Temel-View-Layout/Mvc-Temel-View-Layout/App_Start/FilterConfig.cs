using System.Web;
using System.Web.Mvc;

namespace Mvc_Temel_View_Layout
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
