using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class CourseEnrolement
{
    public int EnrolementId { get; set; }

    public int CourseId { get; set; }

    public int UserGroupId { get; set; }

    public DateTime EnrolementDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public virtual Courese Course { get; set; }

    public virtual UserGroup UserGroup { get; set; }
}
