using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ImageDTO
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public Nullable<int> ImageOrganizationId { get; set; }
        public Nullable<bool> ImageLogo { get; set; }
    }
}
