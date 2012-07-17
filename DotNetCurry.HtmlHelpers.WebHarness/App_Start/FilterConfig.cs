using System.Web;
using System.Web.Mvc;

namespace DotNetCurry.HtmlHelpers.WebHarness
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}