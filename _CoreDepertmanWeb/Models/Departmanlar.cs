using System.ComponentModel.DataAnnotations;

namespace _CoreDepertmanWeb.Models
{
	public class Departmanlar
	{
		[Key]
		public int Id { get; set; }

		public string DepartmanAd { get; set; }
	}
}
