using DoAnLapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLapTrinhWeb.Controllers
{
    public class UsersController : Controller
    {
		// GET: Users
		public ActionResult Index(String UserID="")
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			var model = db.GIAY.ToList();
			db.Dispose();
			return View(model);
		}
		//truyền vào id
		public ActionResult Detail(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			GIAY g = db.GIAY.Where(row => row.Magiay == id).FirstOrDefault();
			return View(g);
		}
		[HttpPost]
		//để tránh nhầm lân giữa 2 action, thêm thuộc tính Product p
		public ActionResult Datail(string id, GIAY g)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			GIAY giay = db.GIAY.Where(row => row.Magiay == id).FirstOrDefault();

			db.SaveChanges();
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
	}

}