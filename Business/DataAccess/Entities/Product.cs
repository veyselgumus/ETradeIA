#nullable disable

using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace Business.DataAccess.Entities
{
    #region entity özellikleri
    public class Product : Record
    {
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Range(0,1000000)]
        public int StockAmount { get; set; }
        public double UnitPrice { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsContinued { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
        
    }
    #endregion
}
