using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using grades;

namespace GradesTests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGradeCorrectly()
        {
            GradeBook book = new GradeBook();
           
            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);

        }

        [TestMethod]
        public void PassByname()
        {

            GradeBook book = new GradeBook();
            book.Name = "Not 1";
            SetName(book);
            Assert.AreEqual("Not 1", book.Name);

        }

        private void SetName(GradeBook book)
        {
            book.Name = "Not 1";
        }


    }
}
