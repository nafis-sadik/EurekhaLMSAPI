using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class UserCourseProgressRecord
{
    public int ProgressRecordId { get; set; }

    public string UserId { get; set; }

    public int ChapterId { get; set; }

    public int CourseId { get; set; }

    public virtual Chapter Chapter { get; set; }

    public virtual Courese Course { get; set; }
}
