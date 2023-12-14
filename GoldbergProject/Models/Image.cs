using System;
using System.Collections.Generic;

namespace GoldbergProject.Models;

public partial class Image
{
    public int ImageId { get; set; }

    public string? ImageName { get; set; }

    public int? ImageOrganizationId { get; set; }

    public bool? ImageLogo { get; set; }

    public virtual Community? ImageOrganization { get; set; }
}
