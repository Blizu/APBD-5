using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APBD5.DAL;
using APBD5.Models;

namespace APBD5.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService service)
        {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetStudent(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("enrollment/{studentId}")]
        public IActionResult GetStudentEnrollment(string studentId)
        {
            IEnumerable<Enrollment> enrollments = _dbService.GetStudentEnrollment(studentId);

            foreach (var enrollment in enrollments)
            {
                Console.WriteLine(enrollment);
            }

            return Ok(enrollments);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok();
        }
    }
}