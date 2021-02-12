using System.Web;
using System.Web.Mvc;

namespace XML_JSON_Serialization_POC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
