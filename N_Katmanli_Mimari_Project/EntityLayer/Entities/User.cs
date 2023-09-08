using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class User
	{
        public int UserID { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Adı")]
		[StringLength(50,ErrorMessage ="Max 50 karakter olmalıdır.")]
		public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyadı")]
		[StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "E-mail")]
		[StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
		[EmailAddress(ErrorMessage ="Lütfen E-mail Formatında Giriniz.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Kullanıcı Adı")]
		[StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Şifre")]
		[StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Şifre Tekrar")]
		[StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
		[DataType(DataType.Password)]
		public string RePassword { get; set; }
		[Required(ErrorMessage = "Boş Geçilemez")]
		[Display(Name = "Rol")]
		[StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
		public string Role { get; set; }
    }
}
