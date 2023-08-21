#nullable disable

using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace Business.DataAccess.Entities
{
    #region entity özellikleri
    public class Category : Record
    {
        
        [Required]
        [StringLength(100)]
        public string Adi { get; set; }

        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
    #endregion
}
