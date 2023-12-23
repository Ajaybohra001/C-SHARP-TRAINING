using FirstWebApi.Data;
using FirstWebApi.Logger;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FirstWebApi.Controllers
{
    [Route("api/StudentController")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentStore _studentStore;

        //private readonly ILogger<StudentController> _logger;

        //public StudentController(ILogger<StudentController> logger)
        //{
        //  _logger=logger;
        //}

        //Creating a custom logger
        private readonly IMyLogger _myLogger;
        public StudentController(IMyLogger logger)
        {
            _myLogger = logger;
            
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Student>> GetStudentList()
        {
            //_logger.LogInformation("Get all students.");
            _myLogger.Log("Get all the students","");
            return Ok(StudentStore.studentList);
        }

        [HttpGet("id:int", Name = "GetStudentList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Student> GetStudentList(int id)
        {
            if (id == 0)
            {
                _myLogger.Log("id is not invalid." + id,"error");
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Student> CreateStudent([FromBody] Student student)
        {
            if(student.studentId<=0)
            {
                _myLogger.Log("Id is not Valid", "error");
                return BadRequest("Id is not Valid");
            }
            if (student == null)
            {
                //_logger.LogInformation("Student is null");
                _myLogger.Log("Id should not be null", "error");
                return BadRequest(student);
            }


            if (student.studentAge < 18)
            {
                ModelState.AddModelError("Not Accepted", "Under Age");
                return BadRequest(ModelState);
            }
            //student.studentId = StudentStore.studentList.OrderByDescending(x => x.studentId).FirstOrDefault().studentId + 1;
            StudentStore.studentList.Add(student);

            return CreatedAtRoute("GetStudentList", new { id = student.studentId }, student);

        }

        [HttpDelete("{id}")]
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
            if(id==0 || updatedStudent==null)
            {
                return BadRequest();
            }
            var existingStudent = StudentStore.studentList.FirstOrDefault(s => s.studentId == id);

            if (existingStudent == null)
            {
                return NotFound();
            }

            existingStudent.studentId = updatedStudent.studentId;
            existingStudent.studentName = updatedStudent.studentName;
             
            return Ok(existingStudent);
        }
        [HttpPatch("id:int", Name = "PartialUpdate")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult PartialUpdateStudent(int id, JsonPatchDocument<Student> patchStudent)
        {
            if (id == 0 || patchStudent == null)
            {
                return BadRequest();
            }
            var partialUpdate = StudentStore.studentList.FirstOrDefault(s => s.studentId == id);
            if (partialUpdate == null)
                return BadRequest();

            patchStudent.ApplyTo(partialUpdate, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }

            return NoContent();
        
        }

    }
}
