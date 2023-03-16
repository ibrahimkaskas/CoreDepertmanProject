using System.ComponentModel.DataAnnotations;

namespace _CoreDepertmanWeb.Models
{
	public class Personel
	{
		[Key]

		public int PerId { get; set; }

		public string Ad { get; set; }

		public string Soyad { get; set; }

		public string Sehir { get; set; }

	}
}
