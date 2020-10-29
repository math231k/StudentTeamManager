using System;
using System.Collections.Generic;
using System.Text;
using StudentTeamManager.Core.Entities;

namespace StudentTeamManager.Core.domainservices
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAllStudents();
    }
}
