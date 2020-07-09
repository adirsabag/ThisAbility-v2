using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Language
    {

        [Key]
        public string id { get; set; }
        public static int count { get; set; }

        public bool Lang { get; set; }

        public string VeryGood { get; set; }

        public string Good { get; set; }
   
        public string Basic { get; set; }
        public Language()
        {
        }
    }
}