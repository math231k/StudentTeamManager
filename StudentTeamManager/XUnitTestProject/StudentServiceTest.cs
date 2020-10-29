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
        private IEnumerable<Student> students = null;
        private readonly Mock<IStudentRepository> studentMock;

        [Fact]
        public void GetAllStudentsTest()
        {

        }
    }
}
