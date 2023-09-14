using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class Courese
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public virtual ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

    public virtual ICollection<CourseEnrolement> CourseEnrolements { get; set; } = new List<CourseEnrolement>();

    public virtual ICollection<UserCourseProgressRecord> UserCourseProgressRecords { get; set; } = new List<UserCourseProgressRecord>();
}
