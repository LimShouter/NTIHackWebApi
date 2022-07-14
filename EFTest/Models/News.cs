using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Models
{
    public class News
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string PublicationTime { get; set; }
    }
}
