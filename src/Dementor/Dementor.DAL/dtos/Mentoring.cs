using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dementor.DAL.dtos
{
    public class Mentoring
    {
        public Guid Id { get; set; }
        public Glober Mentor { get; set; }
        public Glober Mentee { get; set; }
    }
}
