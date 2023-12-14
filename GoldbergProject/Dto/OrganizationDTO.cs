using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class OrganizationDTO
    {
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public Nullable<int> MaximumTheFirstPart { get; set; }
        public string ColorOfFirstPart { get; set; }
        public Nullable<int> MaximumTheSecondPart { get; set; }
        public string ColorOfSecondPart { get; set; }
        public string ColorOfThirddPart { get; set; }
    }
}
