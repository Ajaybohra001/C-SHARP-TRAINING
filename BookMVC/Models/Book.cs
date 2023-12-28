using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{
    public class Book
    {
        [Required]
        public Guid bookId {  get; set; }

        [StringLength(60,MinimumLength =5)]
        public string bookName { get; set; }    
        public string bookAuthor {  get; set; }
    }
}
