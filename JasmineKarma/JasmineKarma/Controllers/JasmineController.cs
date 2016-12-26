using System;
using System.Web.Mvc;

namespace JasmineKarma.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
