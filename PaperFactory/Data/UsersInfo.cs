using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperFactory.Data
{
    public class UsersInfo
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }

        public List<User> Users { get; set; }
    }
}
