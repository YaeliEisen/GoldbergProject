using System;
using System.Collections.Generic;

namespace GoldbergProject.Models;

public partial class Organization
{
    public int OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public int? MaximumTheFirstPart { get; set; }

    public string? ColorOfFirstPart { get; set; }

    public int? MaximumTheSecondPart { get; set; }

    public string? ColorOfSecondPart { get; set; }

    public string? ColorOfThirddPart { get; set; }

    public virtual ICollection<CommunitiesForOrganization> CommunitiesForOrganizations { get; set; } = new List<CommunitiesForOrganization>();
}
