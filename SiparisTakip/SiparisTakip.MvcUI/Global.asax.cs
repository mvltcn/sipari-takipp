using SiparisTakip.Bll;
using SiparisTakip.Cache;
using SiparisTakip.MvcUI.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace SiparisTakip.MvcUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            CacheProvider.Instance = new DefaultCacheProvider();

            CacheFonsiyon fonksiyon = new CacheFonsiyon();
            fonksiyon.CacheTemizle();
            fonksiyon.CacheOlustur();
        }
    }
}
