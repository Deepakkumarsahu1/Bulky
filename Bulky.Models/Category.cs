using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression("([A-Za-z])+( [A-Za-z]+)*", ErrorMessage = "User name should contain only characters.")]
        [MaxLength(30)]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Name should be more than 3 characters")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Display order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
   

}
