using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _grades = new List<float>();
            //i need to initialize the list in teh constructor because a constructor can parse data as well 
        }
        public void AddGrade(float grade)
        {
            //scope of the class
            //store the grade to be able to be use by another classes
            //for this i created a list below and I add an element in the list wich is generic from the method

            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum = sum + grade;

                stats.AverageGrade = sum / _grades.Count;

            }

            return stats;
            
        }

        public string Name;
        private List<float> _grades;


       
    }
}
