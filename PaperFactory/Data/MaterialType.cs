using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperFactory.Data
{
    public class MaterialType
    {
        [Key]
        public int Id { get; set; }
        public string MaterialTypeName { get; set; }

        public List<Material> Materials { get; set; }
    }
}
