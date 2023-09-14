using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Models
{
    public class ChapterModel
    {
        public int ChapterId { get; set; }

        public string ChapterTitle { get; set; }

        public int CourseId { get; set; }
    }
}
