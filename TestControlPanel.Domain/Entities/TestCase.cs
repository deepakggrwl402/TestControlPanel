using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControlPanel.Domain.Entities
{
    public class TestCase
    {
        public int Id { get; set; }
        public string? TestTitle { get; set; }
        public DateTime TestDate { get; set; }
        public string? TestDescription { get; set; }
    }
}
