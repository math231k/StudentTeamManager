using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Moq;
using StudentTeamManager.Core.domainservices;
using StudentTeamManager.Core.Entities;
using Xunit;

namespace XUnitTestProject
{
    public class StudentServiceTest
    {
        private readonly IEnumerable<Student> students = null;
        private readonly Mock<IStudentRepository> studentMock;

        public StudentServiceTest()
        {
            studentMock = new Mock<IStudentRepository>();
            studentMock.Setup(repo => repo.GetAllStudents()).Returns(() => students);
        }

        [Fact]
        public void GetAllStudentsTest()
        {
            //ARRANGE
            //ACT
            //ASSERT

            Assert.NotNull(students);
        }
    }
}
