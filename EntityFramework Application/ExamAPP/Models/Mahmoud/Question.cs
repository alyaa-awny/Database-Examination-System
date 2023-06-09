﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAPP.Models.Mahmoud
{
    public class Question
    {
        public int Q_Id { get; set; }
        public string QuesTitle { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public string AnsTitle { get; set; } = string.Empty;
        public int AnsID { get; set; }
        public int CrsID { get; set; }
        public int Q_Mark { get; set; }
        public ICollection<Choices> Choices { get; set; } = new List<Choices>();
        public Course? Course { get; set; }
        public ICollection<Exam_Question_Crs> Exam_Question_Crs { get; set; } = new List<Exam_Question_Crs>();
        public ICollection<Stude_Answers>? Stude_Answers { get; set; }
        //public Choices? ModelChoice { get; set; }    


    }
}
