using FirstWebApi.Data;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/StudentControlle")]
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
            var student = StudentStore.studentList.FirstOrDefault(x => x.studentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
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

            if(student.studentAge<18)
            {
                ModelState.AddModelError("Not Accepted", "Under Age");
                return BadRequest(ModelState);
            }
            student.studentId = StudentStore.studentList.OrderByDescending(x => x.studentId).FirstOrDefault().studentId + 1;
            StudentStore.studentList.Add(student);

            return CreatedAtRoute("GetStudent", new { id = student.studentId }, student);


        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Student> DeleteStudent(int id)
        {
            var student = StudentStore.studentList.FirstOrDefault(x => x.studentId == id);
            if (student == null)
            {
                return NotFound(student);
            }
            StudentStore.studentList.Remove(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            var existingStudent = StudentStore.studentList.FirstOrDefault(s => s.studentId == id);

            if (existingStudent == null)
            {
                return NotFound();
            }

            existingStudent.studentId = updatedStudent.studentId;
            existingStudent.studentName = updatedStudent.studentName;
             
            return Ok(existingStudent);
        }
    }
}
