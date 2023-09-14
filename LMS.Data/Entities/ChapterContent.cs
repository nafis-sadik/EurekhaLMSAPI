using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class ChapterContent
{
    public int ContentId { get; set; }

    public int ContentTypeId { get; set; }

    public string ContentUrl { get; set; }

    public int? ContentTitle { get; set; }

    public int ChapterId { get; set; }

    public virtual Chapter Chapter { get; set; }

    public virtual ChapterContentType ContentType { get; set; }
}
