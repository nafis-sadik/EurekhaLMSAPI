using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class UserGroup
{
    public int UserGroupId { get; set; }

    public string UserGroupTitle { get; set; }

    public virtual ICollection<CourseEnrolement> CourseEnrolements { get; set; } = new List<CourseEnrolement>();

    public virtual ICollection<UserGroupMember> UserGroupMembers { get; set; } = new List<UserGroupMember>();
}
