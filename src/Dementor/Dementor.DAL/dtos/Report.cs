using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dementor.DAL.dtos
{
    public class Report
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Feedback> MentorsFeedback { get; set; }
    }
}
