using LMS.Data.Models;
using RedBook.Core.Models;

namespace LMS.Domain.Abstractions
{
    public interface ICourseService
    {
        public PagedModel<CourseModel> GetPaged(PagedModel<CourseModel> model);

        public CourseModel CreateAsync(CourseModel model);

        public CourseModel UpdateAsync(CourseModel model);

        public CourseModel DeleteAsync(int courseId);
    }
}
