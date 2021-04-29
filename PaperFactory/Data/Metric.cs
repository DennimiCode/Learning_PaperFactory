using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperFactory.Data
{
    public class Metric
    {
        [Key]
        public int Id { get; set; }
        public string MetricName { get; set; }

        public List<Material> Materials { get; set; }
    }
}
