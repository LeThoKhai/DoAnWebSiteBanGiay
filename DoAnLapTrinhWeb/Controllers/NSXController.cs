using DoAnLapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLapTrinhWeb.Controllers
{
    public class NSXController : Controller
    {
		// GET: NSX
		public ActionResult Index(string search = "")
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			List<NHASANXUAT> nsx = db.NHASANXUAT.Where(row => row.TenSX.Contains(search)).ToList();
			db.Dispose();
			return View(nsx);
		}
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(NHASANXUAT nsx)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			db.NHASANXUAT.Add(nsx);
			db.SaveChanges();
			//db.Dispose();
			//tra ve trang index
			return RedirectToAction("Index");
		}
		public ActionResult Edit(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			NHASANXUAT nsx = db.NHASANXUAT.Where(row => row.MaSX == id).FirstOrDefault();
			return View(nsx);
		}
		[HttpPost]
		public ActionResult Edit(NHASANXUAT nhasanxuat)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			NHASANXUAT nsx = db.NHASANXUAT.Where(row => row.MaSX ==  nhasanxuat.MaSX).FirstOrDefault();
			nsx.MaSX = nhasanxuat.MaSX;
			nsx.TenSX = nhasanxuat.TenSX;
			nsx.Diachi= nhasanxuat.Diachi;
			nsx.Dienthoai=nhasanxuat.Dienthoai;
			db.SaveChanges();
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
		public ActionResult Delete(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			NHASANXUAT nsx = db.NHASANXUAT.Where(row => row.MaSX == id).FirstOrDefault();
			return View(nsx);
		}
		[HttpPost]
		//để tránh nhầm lân giữa 2 action, thêm thuộc tính Product p
		public ActionResult Delete(string id, NHASANXUAT nhasanxuat)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			NHASANXUAT  nsx= db.NHASANXUAT.Where(row => row.MaSX == id).FirstOrDefault();
			db.NHASANXUAT.Remove(nsx);
			db.SaveChanges();
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
	}
}