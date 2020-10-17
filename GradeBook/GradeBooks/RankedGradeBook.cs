using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook
    {

        //public GradeBookType Type { get; set; }
        public RankedGradeBook(string name) :base(name)
        {
            this.Type = GradeBookType.Ranked;
        }


        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }

            int j = 0;
            foreach (var student in Students)
            {
                
                if(averageGrade < student.AverageGrade)
                {
                    j++;
                }
                
            }

            
            double rank = ((Students.Count-j-1 ) * 100)/ Students.Count;





            if ( rank >= 80)
                return 'A';
            else if (rank >= 60)
                return 'B';
            else if (rank >= 40)
                return 'C';
            else if (rank >= 20)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            // base.CalculateStatistics();

            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            

            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
