using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaperFactory.Data
{
    public class Material
    {
        [Key]
        public int Id { get; set; }
        public string NameOfMaterial { get; set; }
        public int TypeOfMaterial { get; set; }
        public string MaterialImage { get; set; }
        public decimal Price { get; set; }
        public decimal WarehouseAmount { get; set; }
        public decimal MinWarehouseAmount { get; set; }
        public decimal AmountInPack { get; set; }
        public int TypeOfMetric { get; set; }

        [ForeignKey("TypeOfMetric")]
        public Metric Metric { get; set; }

        [ForeignKey("TypeOfMaterial")]
        public MaterialType MaterialType { get; set; }
    }
}
