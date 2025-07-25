﻿using System.Linq;
using System.Web.Http.Cors;
using System.Web.Mvc;
using ShortsMVC.Models;



[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
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

