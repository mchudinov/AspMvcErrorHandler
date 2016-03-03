using System.Web.Mvc;

namespace AspMvcErrorHandler.Controllers
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