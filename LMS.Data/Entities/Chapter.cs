using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class Chapter
{
    public int ChapterId { get; set; }

    public string ChapterTitle { get; set; }

    public int CourseId { get; set; }

    public virtual ICollection<ChapterContent> ChapterContents { get; set; } = new List<ChapterContent>();

    public virtual Courese Course { get; set; }

    public virtual ICollection<UserCourseProgressRecord> UserCourseProgressRecords { get; set; } = new List<UserCourseProgressRecord>();
}
