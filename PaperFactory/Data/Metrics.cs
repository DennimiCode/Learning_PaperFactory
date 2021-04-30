using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperFactory.Data
{
    public class Metrics
    {
        [Key]
        public int Id { get; set; }
        public string MetricName { get; set; }

        public List<Materials> Materials { get; set; }
    }
}
