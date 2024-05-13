using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorOnline.Models
{
	public class Product
	{
		public int ProductId { get; set; }

		[NotMapped]
		public IFormFile? ProductImage { get; set; }

		[StringLength(500)]
		public string? ImageUrl { get; set; }

		[Required]
		public string? Productname { get; set; }

		[Required]
		public string? Brand { get; set; }
		public string? Description { get; set; }

		[Required]
		[Display (Name="Price")]
		public decimal Deliver { get; set; }

		[Required]
		public int Quantity { get; set; }
	}
}
