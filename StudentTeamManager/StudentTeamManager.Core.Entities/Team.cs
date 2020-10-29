using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace StudentTeamManager.Core.Entities
{
    public class Team
    {
        private int Id { get; set; }
        private IEnumerable<Student> Students { get; set; }
    }
}
