using Recipe_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recipe_Portal.Controllers
{
    public class FindRecipeController : Controller
    {
        // GET: FindRecipe
        //[Authorize]
        public ActionResult FindRecipe()
        {
            ViewBag.Message = "Your application Find Recipe page.";
            return View();
        }
       
    }
}