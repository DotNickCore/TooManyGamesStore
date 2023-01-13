using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooManyGamesStore.BL.Models
{
    public class Platform
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public Brand PlatformBrand { get; set; }
    }
}
