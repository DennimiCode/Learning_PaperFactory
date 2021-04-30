using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperFactory.Data
{
    public class MaterialsTypes
    {
        [Key]
        public int Id { get; set; }
        public string MaterialTypeName { get; set; }

        public List<Materials> Materials { get; set; }
    }
}
