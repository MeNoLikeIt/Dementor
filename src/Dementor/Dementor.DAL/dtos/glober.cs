using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dementor.DAL.dtos
{
    public class Glober
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TechnicalLeader { get; set; }
        public int Status { get; set; }
    }
}
