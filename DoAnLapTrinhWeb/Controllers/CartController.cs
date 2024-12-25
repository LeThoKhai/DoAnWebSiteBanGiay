using DoAnLapTrinhWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLapTrinhWeb.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index(string id)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            List<CHITIETDONDATHANG> cartdetail = db.CHITIETDONDATHANG.Where(row => row.MaDonHang.Contains(id)).ToList();
            return View(cartdetail);
        }
        public ActionResult AddToCart(string userId, string magiay, string soluong)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            // Kiểm tra xem người dùng đã đăng nhập chưa
            if (string.IsNullOrEmpty(userId))
            {
                // Xử lý trường hợp người dùng chưa đăng nhập
                return RedirectToAction("Login", "Account");
            }

            // Chuyển đổi đơn giá từ chuỗi sang số thực
            decimal dongia = db.GIAY.Where(row => row.Magiay == magiay).Select(row => row.Giagiay).FirstOrDefault();
            DONDATHANG cart = db.DONDATHANG.FirstOrDefault(row => row.MaDonHang == userId);
            if (cart != null)
            {
                CHITIETDONDATHANG cartdetail = new CHITIETDONDATHANG();
                cartdetail.MaDonHang = userId;
                cartdetail.Soluong =int.Parse(soluong)+1 ;
                cartdetail.Dongia = dongia;
                cartdetail.Magiay = magiay;
                db.CHITIETDONDATHANG.Add(cartdetail);
            }
            else
            {
                DONDATHANG newcart = new DONDATHANG();
                newcart.MaDonHang = userId;
                newcart.Ngaydat = DateTime.Now;
                newcart.MaKH = userId;
                newcart.Dathanhtoan = false;
                db.DONDATHANG.Add(newcart);
                db.SaveChanges();

                // Kiểm tra lại nếu giỏ hàng vẫn không tồn tại sau khi tạo mới
                if (newcart.MaDonHang != null)
                {
                    CHITIETDONDATHANG cartdetail = new CHITIETDONDATHANG();
                    cartdetail.MaDonHang = userId;
                    cartdetail.Soluong = int.Parse(soluong) + 1;
                    cartdetail.Dongia = dongia;
                    cartdetail.Magiay = magiay;
                    db.CHITIETDONDATHANG.Add(cartdetail);
                }
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Users");
        }
        //để tránh nhầm lân giữa 2 action, thêm thuộc tính Product p
        public ActionResult Delete(string id)
        {
            WebBanGiayDataEntities1 db = new WebBanGiayDataEntities1();
            CHITIETDONDATHANG detail = db.CHITIETDONDATHANG.Where(row => row.Magiay == id).FirstOrDefault();
            db.CHITIETDONDATHANG.Remove(detail);
            db.SaveChanges();
            //sau khi xong chuyển hướng về lại index
            return RedirectToAction("Index", "Users");
        }
    }
}