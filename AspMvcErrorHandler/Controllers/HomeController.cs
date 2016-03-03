using System.Web.Mvc;

namespace MvcErrorHandler.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return DataProvider.GetData();
        }
    }
}