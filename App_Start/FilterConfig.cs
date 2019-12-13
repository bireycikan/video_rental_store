using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // Bütün controller üzerinde etki yaratır. Global olarak filter eklemiş oluyoruz bu şekilde. Erişilmesini istediğimiz alanlara da gidip AllowAnonymous yazarsak gereken izni vermiş oluruz.
            //filters.Add(new AuthorizeAttribute());


            // Gelen isteklerin https üzerinden gelmesini kesin kılar. Http üzerinden gelen istekleri kabul etmez.
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
