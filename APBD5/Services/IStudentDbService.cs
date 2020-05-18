using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD5.DTOs.Requests;
using APBD5.Models;

namespace APBD5.Services
{
    public interface IStudentDbService
    {
        public bool PromoteStudent(PromoteStudentRequest promoteStudentRequest);

        public EnrollStudent EnrollStudent(EnrollStudentRequest enrollStudentRequest);

        public Study GetStudy(string nameOfStudy);
    }
}
