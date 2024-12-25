using DoAnLapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLapTrinhWeb.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index(string search="")
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            List<TAIKHOAN> tk = db.TAIKHOAN.Where(row => row.Hoten.Contains(search)).ToList();
            db.Dispose();
            return View(tk);
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {       
            return View();
        }
        [HttpPost]
        public ActionResult Register(TAIKHOAN tk)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            if (ModelState.IsValid)
            {
                if (tk.IDtaikhoan != null || tk.IDtendangnhap != null ||tk.Password!=null ||tk.Hoten != null || tk.Email != null || tk.Diachi != null) {
                    var user = db.TAIKHOAN.SingleOrDefault(u => (u.IDtaikhoan == tk.IDtaikhoan));
                    if (user != null)
                    {
                        ViewBag.Error = "Tài khoản đã tồn tại";
                        return View();
                    }
                    else
                    {
                        tk.LoaiTK = "Khách hàng";
                        db.TAIKHOAN.Add(tk);
                        db.SaveChanges();
                        db.Dispose();
                       return RedirectToAction("Login", "Accounts");
                    }
                }
            }
            ViewBag.Error = "Thông tin chưa điền đầy đủ";
            return View();
        }
        [HttpPost]
        public ActionResult Login(TAIKHOAN tk)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            if (ModelState.IsValid)
            {
                // Tìm kiếm tài khoản trong cơ sở dữ liệu dựa trên username hoặc email (tùy vào cách bạn lưu trữ)
                var user = db.TAIKHOAN.SingleOrDefault(u => (u.IDtaikhoan == tk.IDtaikhoan));
                if (user != null)
                {
                    // So sánh mật khẩu đã nhập với mật khẩu lưu trữ
                    if (tk.Password.Equals(user.Password))
                    {
                        if (user.LoaiTK.Equals("Admin"))
                        {
                            Session["UserId"] = user.IDtaikhoan;
                            ViewBag.UserName = user.IDtaikhoan;
                            return RedirectToAction("Index", "Products");
                        }
                        Session["UserId"] = user.IDtaikhoan;
                        ViewBag.UserName = user.IDtaikhoan;
                        return RedirectToAction("Index", "Users");
                    }
                }
            }
            ViewBag.Error = "Tên đăng nhập hoặc mật khẩu không chính xác.";
            return View("Login"); // Thay "Login" bằng tên của trang đăng nhập của bạn
        }
        public ActionResult Edit(string id)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            TAIKHOAN tk = db.TAIKHOAN.Where(row => row.IDtaikhoan == id).FirstOrDefault();
            return View(tk);
        }
        [HttpPost]
        public ActionResult Edit(TAIKHOAN tk)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            TAIKHOAN taikhoan = db.TAIKHOAN.Where(row => row.IDtaikhoan == tk.IDtaikhoan).FirstOrDefault();
            taikhoan.IDtendangnhap = tk.IDtendangnhap;
            taikhoan.Hoten = tk.Hoten;
            taikhoan.Email = tk.Email;
            taikhoan.Diachi = tk.Diachi;
            if (Request.Form["loaitk"] != null && Request.Form["loaitk"] == "on")
            {
                taikhoan.LoaiTK = "Admin";
            }
            else
            {
                taikhoan.LoaiTK = "Khách hàng";
            }
            db.SaveChanges();
            //sau khi xong chuyển hướng về lại index
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();

            TAIKHOAN tk = db.TAIKHOAN.Where(row => row.IDtaikhoan == id).FirstOrDefault();
            return View(tk);
        }
        [HttpPost]
        //để tránh nhầm lân giữa 2 action, thêm thuộc tính Product p
        public ActionResult Delete(string id, TAIKHOAN tk)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            TAIKHOAN taikhoan = db.TAIKHOAN.Where(row => row.IDtaikhoan == id).FirstOrDefault();
            DONDATHANG dondathang=db.DONDATHANG.Where(row => row.MaKH==id).FirstOrDefault();
            CHITIETDONDATHANG chitiet = db.CHITIETDONDATHANG.Where(row => row.MaDonHang == id).FirstOrDefault();
            db.CHITIETDONDATHANG.Remove(chitiet);
            db.DONDATHANG.Remove(dondathang);
            db.TAIKHOAN.Remove(taikhoan);
            db.SaveChanges();
            //sau khi xong chuyển hướng về lại index
            return RedirectToAction("Index");
        }
    }
}