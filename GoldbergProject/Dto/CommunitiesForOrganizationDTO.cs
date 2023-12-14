using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CommunitiesForOrganizationDTO
    {
        public int CommunitiesForOrganizationsId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public Nullable<int> CommunityId { get; set; }
        public Nullable<int> AmountOfPercent { get; set; }
    }
}
