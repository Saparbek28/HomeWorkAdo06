using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class Security : Entity
    {
        public string Name { get; set; }
        public DateTime ComeIn { get; set; } = new DateTime();
        public DateTime Released { get; set; } = new DateTime();
        public int Password { get; set; }
        public string Target { get; set; }
    }
}
