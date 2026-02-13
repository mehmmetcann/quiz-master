using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public Question()
        {
            Answers = new List<Answer>();
            CreatedDate = DateTime.Now;
        }
    }
}
