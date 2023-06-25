using System.ComponentModel.DataAnnotations;
using FPTBook.Areas.Identity.Data;
namespace FPTBook.Models;
public class Order
{
        public int Id { get; set; }       
        [DataType(DataType.Date)]
        public DateTime OrderTime { get; set; }
        public decimal? Total { get; set; }
        public string? State{ get; set; }
        public string? UserID { get; set; }
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        [Required, StringLength(10)]
        public string Phone { get; set; }
        public int Quantity { get; set;}
        public ICollection<OrderItem>? OrderItem { get; set; }
        public BookUser? BookUser { get; set; }
}
