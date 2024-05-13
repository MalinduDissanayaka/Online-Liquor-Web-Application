using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorOnline.Models
{
    public class Deliver
    {
        [Key]
        public int DeliverId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [NotMapped]
        public DateOnly DeliverDate {  get; set; }
       // [NotMapped]
      //  public DateOnly EndDate { get; set;}
    }
}
