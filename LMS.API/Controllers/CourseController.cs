using LMS.Data.Models;
using LMS.Domain.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBook.Core.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace LMS.WebAPI.Controllers
{
    /// <summary>
    /// Course Module
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        /// <summary>
        /// Application Module Constructor
        /// </summary>
        /// <param name="courseService">An implementation of <see cref="ICourseService"/> injected by IOC Controller.</param>
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        /// <summary>
        /// Create new course details
        /// </summary>
        /// <param name="model">An object of type <see cref="CourseModel"/></param>
        [HttpPost]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult Create(CourseModel model) { throw new NotImplementedException(); }

        /// <summary>
        /// Update existing course details
        /// </summary>
        /// <param name="model">An object of type <see cref="CourseModel"/></param>
        [HttpPut]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult Update(CourseModel model) { throw new NotImplementedException(); }

        /// <summary>
        /// Delete existing course details (Deletes all the chapters and course contents)
        /// </summary>
        /// <param name="courseId">An object of type <see cref="int"/></param>
        [HttpDelete]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult Delete(int courseId) { throw new NotImplementedException(); }

        /// <summary>
        /// Returns a paginated list of existing courses
        /// </summary>
        /// <param name="pagedModel">An object of type <see cref="PagedModel&lt;CourseModel&gt;"/></param>
        [HttpGet]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult GetPaged([FromQuery] PagedModel<CourseModel> pagedModel) { throw new NotImplementedException(); }
    }
}
