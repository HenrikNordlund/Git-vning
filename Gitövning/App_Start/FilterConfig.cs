using System.Web;
using System.Web.Mvc;

namespace Gitövning
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());


            //Här kommer mitt bidrag
            System.Console.WriteLine("Henrik Nordlund har gjort en ändring!");
            
        }
        
    }
}
