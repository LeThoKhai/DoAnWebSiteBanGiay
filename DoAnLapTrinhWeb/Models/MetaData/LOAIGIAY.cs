using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnLapTrinhWeb.Models
{
	public partial class LOAIGIAY
	{
		[MetadataType(typeof(LOAIGIAY.MetaData))]
		sealed class MetaData
		{
			[Required(AllowEmptyStrings = false, ErrorMessage = "Mã loại giày không được để trống")]
			public string Maloai { get; set; }
			[Required(AllowEmptyStrings = false, ErrorMessage = "Tên loại giày không được để trống")]
			public string Tenloai { get; set; }
		}
	}
}