using DoAnLapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLapTrinhWeb.Controllers
{
    public class CategoriesController : Controller
	{
		// GET: Categories
		public ActionResult Index(string search = "")
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			List<LOAIGIAY> lOAIGIAYs = db.LOAIGIAY.Where(row => row.Tenloai.Contains(search)).ToList();
			db.Dispose();
			return View(lOAIGIAYs);
		}
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(LOAIGIAY loaigiay)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			db.LOAIGIAY.Add(loaigiay);
			db.SaveChanges();
			//tra ve trang index
			return RedirectToAction("Index");
		}
		public ActionResult Edit(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			LOAIGIAY loaigiay = db.LOAIGIAY.Where(row => row.Maloai == id).FirstOrDefault();
			return View(loaigiay);
		}
		[HttpPost]
		public ActionResult Edit(LOAIGIAY loaigiay)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			LOAIGIAY Lg = db.LOAIGIAY.Where(row => row.Maloai == loaigiay.Maloai).FirstOrDefault();
			Lg.Maloai = loaigiay.Maloai;
			Lg.Tenloai = loaigiay.Tenloai;
			db.SaveChanges();
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
		public ActionResult Delete(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();

			LOAIGIAY lg = db.LOAIGIAY.Where(row => row.Maloai == id).FirstOrDefault();
			return View(lg);
		}
		[HttpPost]
		//để tránh nhầm lân giữa 2 action, thêm thuộc tính Product p
		public ActionResult Delete(string id, LOAIGIAY g)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			LOAIGIAY loaigiays = db.LOAIGIAY.Where(row => row.Maloai == id).FirstOrDefault();
			db.LOAIGIAY.Remove(loaigiays);
			db.SaveChanges();
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
	}
}