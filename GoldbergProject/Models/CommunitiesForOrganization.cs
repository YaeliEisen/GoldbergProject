using System;
using System.Collections.Generic;

namespace GoldbergProject.Models;

public partial class CommunitiesForOrganization
{
    public int CommunitiesForOrganizationsId { get; set; }

    public int? OrganizationId { get; set; }

    public int? CommunityId { get; set; }

    public int? AmountOfPercent { get; set; }

    public virtual Community? Community { get; set; }

    public virtual Organization? Organization { get; set; }
}
