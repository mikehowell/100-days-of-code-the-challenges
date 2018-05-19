using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var grading = new Grading();
                //var gradeList = grading.RoundGrades(4, 73, 67, 38, 33);
                var gradeList = grading.RoundGrades(1, 99);

                foreach (var grade in gradeList)
                {
                    Console.WriteLine(grade);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The following error has occurred:\r\n\r\n{0}", e.Message);
            }

        }
    }
}
