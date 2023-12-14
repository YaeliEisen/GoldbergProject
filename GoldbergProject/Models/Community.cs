using System;
using System.Collections.Generic;

namespace GoldbergProject.Models;

public partial class Community
{
    public int CommunityId { get; set; }

    public string? CommunityName { get; set; }

    public virtual ICollection<CommunitiesForOrganization> CommunitiesForOrganizations { get; set; } = new List<CommunitiesForOrganization>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
