using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnLapTrinhWeb.Models
{
	public partial class GIAY
	{
		public int soluong { get; set; }

		[MetadataType(typeof(GIAY.MetaData))]
		sealed class MetaData
		{
				[Required(AllowEmptyStrings =false,ErrorMessage ="Mã giày không được để trống")]
				public string Magiay { get; set; }
				[Required(AllowEmptyStrings = false, ErrorMessage = "Tên giày không được để trống")]
				public string Tengiay { get; set; }
				[Required(AllowEmptyStrings = false, ErrorMessage = "Kích thước không được để trống")]
				[Range(1,int.MaxValue,ErrorMessage ="Kích thước phải lớn hơn 0")]
				public int Size { get; set; }
				[Required(AllowEmptyStrings = false, ErrorMessage = "Kích thước không được để trống")]
				[Range(1, int.MaxValue, ErrorMessage = "Giá giày phải lớn hơn 0")]
				public decimal Giagiay { get; set; }
				public string Mota { get; set; }
				public string Anhbia { get; set; }
				public System.DateTime Ngaycapnhat { get; set; }
				[Required(AllowEmptyStrings = false, ErrorMessage = "Số lượng tồn không được để trống")]
				[Range(1, int.MaxValue, ErrorMessage = "Kích thước phải lớn hơn 0")]
				public int Soluongton { get; set; }
				[Required(AllowEmptyStrings = false, ErrorMessage = "Mã loại không được để trống")]
				public string Maloai { get; set; }
				[Required(AllowEmptyStrings = false, ErrorMessage = "Mã nhà sản xuất không được để trống")]
				public string MaSX { get; set; }
		}
	}
}