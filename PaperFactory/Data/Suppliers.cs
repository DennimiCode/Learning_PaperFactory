using System.ComponentModel.DataAnnotations;

namespace PaperFactory.Data
{
    public class Suppliers
    {
        [Key]
        public int Id { get; set; }
        public string NameOfMaterial { get; set; }
        public string PossibleSupplier { get; set; }
    }
}
