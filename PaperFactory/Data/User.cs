using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaperFactory.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int InfoId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [ForeignKey("InfoId")]
        public UsersInfo UsersInfo { get; set; }
    }
}
