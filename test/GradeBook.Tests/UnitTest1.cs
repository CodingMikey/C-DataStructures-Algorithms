using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(90.5);
            book.AddGrade(100);
            book.AddGrade(75);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.5, result.Average);
            Assert.Equal(85.5, result.High);
            Assert.Equal(85.5, result.Average);
        }
    }
}
