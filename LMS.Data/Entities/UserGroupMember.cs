using System;
using System.Collections.Generic;

namespace LMS.Entities;

public partial class UserGroupMember
{
    public int GroupingRecordId { get; set; }

    public int UserGroupId { get; set; }

    public string UserId { get; set; }

    public virtual UserGroup UserGroup { get; set; }
}
