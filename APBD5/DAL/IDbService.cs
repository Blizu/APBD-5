using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD5.Models;

namespace APBD5.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
        public Study GetStudy(string studyName);
        public IEnumerable<Enrollment> GetStudentEnrollment(string studentId);

        
    }
}

