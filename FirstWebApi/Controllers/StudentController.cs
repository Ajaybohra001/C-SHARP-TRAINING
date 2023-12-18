﻿using FirstWebApi.Data;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Student>> GetStudentList()
        {
            return Ok(StudentStore.studentList);
        }

        [HttpGet("id:int", Name = "GetStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Student> GetStudentList(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var studnet = StudentStore.studentList.FirstOrDefault(x => x.studentId == id);
            if (studnet == null)
            {
                return NotFound();
            }

            return Ok(studnet);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Student> CreateStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest(student);
            }
            if (student.studentId > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            student.studentId = StudentStore.studentList.OrderByDescending(x => x.studentId).FirstOrDefault().studentId + 1;
            StudentStore.studentList.Add(student);

            return CreatedAtRoute("GetStudent", new { id = student.studentId }, student);

        }
    }
}
