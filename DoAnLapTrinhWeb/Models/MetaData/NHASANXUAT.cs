using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnLapTrinhWeb.Models
{
	public partial class NHASANXUAT
	{
		[MetadataType(typeof(NHASANXUAT.MetaData))]

		sealed class MetaData
		{
			[Required(AllowEmptyStrings = false, ErrorMessage = "Tên nhà sản xuất không được để trống")]
			public string MaSX { get; set; }
			[Required(AllowEmptyStrings = false, ErrorMessage = "Tên nhà sản xuất không được để trống")]
			public string TenSX { get; set; }
			[Required(AllowEmptyStrings = false, ErrorMessage = "Địa chỉ không được để trống")]

			public string Diachi { get; set; }
			[Required(AllowEmptyStrings = false, ErrorMessage = "Điện thoại không được để trống")]
			public string Dienthoai { get; set; }
		}
	}
}