using System.Web.Mvc;

namespace MvcErrorHandler.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            //throw new System.Exception("Hehe!");
            return DataProvider.GetData();
        }
    }
}