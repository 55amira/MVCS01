using Microsoft.AspNetCore.Mvc;
using MVCS01.Models;
using System.Net.Mime;

namespace MVCS01.Controllers
{
    public class MoiveController : Controller
    {
        // Actions public non-static method

        //public String GetMoive(int id)
        //{
        //    return $"Get Moive with {id}";
        //}

        //public String AddMoive(int id)
        //{
        //    return $"Add Moive with {id}";
        //}

        //public ContentResult GetMoive(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Moive with {id}",
        //        ContentType= "text/html",
        //        StatusCode= 200
        //    };



        //    return contentResult;
        //}

        //public ContentResult GetMoive(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Moive with {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200
        //    };

        //    return contentResult;
        //}

        //public RedirectResult GetMoive(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com/");


        //    return redirectResult;
        //}

        //public RedirectToActionResult GetMoive(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMoive","Moive",new{ id = 133});


        //    return redirectToActionResult;
        //}
        //[ActionName ( "GetMoive")]
        //public IActionResult GetMoiveByIdCatgoryDramaAndPoster(int id)
        //{
        //    if (id == 1)
        //    {
        //       // return  new ContentResult(){Content = $"Get Moive with {id}",ContentType= "text/html"};
        //       return Content ( $"Get Moive with {id}", "text/html");
        //}
        //    else if (id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Moive with {id}", ContentType = "object/pdf" };
        //        return Content($"Get Moive with {id}","object/pdf");
        //    }
        //    else if (id == 3)
        //    {
        //        //return new RedirectResult("https://www.google.com/");
        //        return  Redirect("https://www.google.com/");
        //    }
        //    else 
        //    {
        //        // return new RedirectToActionResult("AddMoive", "Moive", new { id = 133 });
        //        return  RedirectToAction("AddMoive", "Moive", new { id = 133 });
        //    }
        //}

        //public String AddMoive(int id)
        //{
        //    return $"Add Moive with {id}";
        //}

        public IActionResult GetMoive(Moive moive)
        {
            return Content($"Get Moive with id : {moive.Id}, name : {moive.Name}", "text/html");
        }
    }
}
