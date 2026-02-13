using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Entities
{
    public class Result
    {
        public int ResultId { get; set; }
        public string UserName { get; set; }

        public int Score { get; set; }
        public int totalQuestions { get; set; }

        public int TimeSpentSeconds { get; set; }
        public DateTime ExamDate { get; set; }

        public Result()
        {
            ExamDate = DateTime.Now;
        }

    }
}
