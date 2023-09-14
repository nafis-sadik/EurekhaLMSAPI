using LMS.Data.Models;
using LMS.Domain.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBook.Core.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace LMS.WebAPI.Controllers
{
    /// <summary>
    /// Chapter Module
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService _chapterService;

        /// <summary>
        /// Chapter Module Constructor
        /// </summary>
        /// <param name="chapterService">An implementation of <see cref="IChapterService"/> injected by IOC Controller.</param>
        public ChapterController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        /// <summary>
        /// Create new chapter details
        /// </summary>
        /// <param name="model">An object of type <see cref="ChapterModel"/></param>
        [HttpPost]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult Create(ChapterModel model) { throw new NotImplementedException(); }

        /// <summary>
        /// Update existing chapter details
        /// </summary>
        /// <param name="model">An object of type <see cref="ChapterModel"/></param>
        [HttpPut]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult Update(ChapterModel model) { throw new NotImplementedException(); }

        /// <summary>
        /// Delete existing chapter details (Deletes all the chapters and chapter contents)
        /// </summary>
        /// <param name="courseId">An object of type <see cref="int"/></param>
        [HttpDelete]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult Delete(int courseId) { throw new NotImplementedException(); }

        /// <summary>
        /// Returns a paginated list of existing courses
        /// </summary>
        /// <param name="pagedModel">An object of type <see cref="PagedModel&lt;ChapterModel&gt;"/></param>
        [HttpGet]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        public IActionResult GetPaged([FromQuery] PagedModel<ChapterModel> pagedModel) { throw new NotImplementedException(); }
    }
}
