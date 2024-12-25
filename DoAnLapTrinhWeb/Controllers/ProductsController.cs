using DoAnLapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DoAnLapTrinhWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

		public ActionResult Index(string search="")
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			List<GIAY> products = db.GIAY.Where(row => row.Tengiay.Contains(search)).ToList();
			db.Dispose();
			return View(products);
		}
		public ActionResult Create()
		{
			
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			List<LOAIGIAY> lg=db.LOAIGIAY.ToList();
			List<NHASANXUAT> nsx = db.NHASANXUAT.ToList();
			ViewBag.DSLOAIGIAY = new SelectList(lg, "Maloai", "Tenloai");
			ViewBag.DSNHASANXUAT = new SelectList(nsx, "MaSX", "Tensx");
			return View();
		}
		[HttpPost]
		public ActionResult Create(GIAY giay, HttpPostedFileBase uploadhinh)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			List<LOAIGIAY> lg = db.LOAIGIAY.ToList();
			List<NHASANXUAT> nsx = db.NHASANXUAT.ToList();
			ViewBag.DSLOAIGIAY = new SelectList(lg, "Maloai", "Tenloai");
			ViewBag.DSNHASANXUAT = new SelectList(nsx, "MaSX", "Tensx");
			try
			{
					db.GIAY.Add(giay);
					db.SaveChanges();
					if (uploadhinh != null && uploadhinh.ContentLength > 0)
					{
						/*				string id = db.GIAY.ToList().Last().Magiay.ToString();
										string File_Name = "";
										int index = uploadhinh.FileName.IndexOf('.');
										File_Name = "sp" + id.ToString() + uploadhinh.FileName.Substring(index + 1);
										string _path = Path.Combine(Server.MapPath("~/Upload/Product"), File_Name);
										uploadhinh.SaveAs(_path);
										GIAY g = db.GIAY.FirstOrDefault(row => row.Magiay == id);
										g.Anhbia = File_Name;
										db.SaveChanges();*/
						string fileName = Path.GetFileName(uploadhinh.FileName);
						string path = Path.Combine(Server.MapPath("~/imgs/giay"), fileName);
						uploadhinh.SaveAs(path);
						GIAY g = db.GIAY.Where(row => row.Magiay == giay.Magiay).FirstOrDefault();
						// Cập nhật đường dẫn hình ảnh mới vào sản phẩm
						g.Anhbia = fileName;
						db.SaveChanges();
					}
					//tra ve trang index
					return RedirectToAction("Index");
				// Code xử lý
			}
			catch (Exception ex)
			{
				// Trả về thông báo lỗi bằng JavaScript
				ViewBag.ErrorMessage = "LOI NHAP LIEU VUI LONG NHAP DUNG KIEU DU LIEU";
				return View();
			}
		}
		public ActionResult Edit(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			GIAY giay = db.GIAY.Where(row => row.Magiay == id).FirstOrDefault();
			return View(giay);
		}
		[HttpPost]
		public ActionResult Edit(GIAY giay, HttpPostedFileBase uploadhinh)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			GIAY g = db.GIAY.Where(row => row.Magiay == giay.Magiay).FirstOrDefault();
			g.Magiay = giay.Magiay;
			g.Tengiay = giay.Tengiay;
			g.Size = giay.Size;
			g.Giagiay = giay.Giagiay;
			g.Mota=giay.Mota;
			g.Anhbia = giay.Anhbia;
			g.Ngaycapnhat=giay.Ngaycapnhat;
			g.Soluongton=giay.Soluongton;
			g.Maloai=giay.Maloai;
			g.MaSX=giay.MaSX;
			g.Hot=giay.Hot;
			db.SaveChanges();
			if (uploadhinh != null && uploadhinh.ContentLength > 0)
			{
				/*				string id = db.GIAY.ToList().Last().Magiay.ToString();
								string File_Name = "";
								int index = uploadhinh.FileName.IndexOf('.');
								File_Name = "sp" + id.ToString() + uploadhinh.FileName.Substring(index + 1);
								string _path = Path.Combine(Server.MapPath("~/Upload/Product"), File_Name);
								uploadhinh.SaveAs(_path);
								GIAY g = db.GIAY.FirstOrDefault(row => row.Magiay == id);
								g.Anhbia = File_Name;
								db.SaveChanges();*/
				string fileName = Path.GetFileName(uploadhinh.FileName);
				string path = Path.Combine(Server.MapPath("~/imgs/giay"), fileName);
				uploadhinh.SaveAs(path);
				// Cập nhật đường dẫn hình ảnh mới vào sản phẩm
				g.Anhbia = fileName;
				db.SaveChanges();
			}
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
		public ActionResult Delete(string id)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();

			GIAY g = db.GIAY.Where(row => row.Magiay == id).FirstOrDefault();
			return View(g);
		}
		[HttpPost]
		//để tránh nhầm lân giữa 2 action, thêm thuộc tính Product p
		public ActionResult Delete(string id, GIAY g)
		{
			WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
			GIAY giay = db.GIAY.Where(row => row.Magiay == id).FirstOrDefault();
			db.GIAY.Remove(giay);
			db.SaveChanges();
			//sau khi xong chuyển hướng về lại index
			return RedirectToAction("Index");
		}
	}
}