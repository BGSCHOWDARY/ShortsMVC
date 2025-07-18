using System.Linq;
using System.Web.Http.Cors;
using System.Web.Mvc;
using ShortsMVC.Models;



public class ShortsController : Controller

{
    private ShortsDbContext db = new ShortsDbContext();
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    [HttpGet]
    public JsonResult GetAllShorts()
    {
        var data = db.Shorts.ToList();
        return Json(data, JsonRequestBehavior.AllowGet);
    }
}

