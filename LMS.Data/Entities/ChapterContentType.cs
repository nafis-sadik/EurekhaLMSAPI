using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class ChapterContentType
{
    public int ContentTypeId { get; set; }

    public string ContentTypeName { get; set; }

    public virtual ICollection<ChapterContent> ChapterContents { get; set; } = new List<ChapterContent>();
}
