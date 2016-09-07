using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dementor.DAL.dtos
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public Glober Mentor { get; set; }
        public Glober Mentee { get; set; }
        public DateTime Date { get; set; }
        public Mood GloberMood { get; set; }
        public string Description { get; set; }
    }
}
