using System.Web;
using System.Web.Mvc;

namespace BigSchool_2011068957
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
