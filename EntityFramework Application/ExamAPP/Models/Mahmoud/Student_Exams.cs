
namespace ExamAPP.Models.Mahmoud;

public class Student_Exams
{

    public int St_ID { get; set; }

    public int Ex_ID { get; set; }

    public Student? Student { get; set; }

    public Exam? Exam { get; set; }
}
