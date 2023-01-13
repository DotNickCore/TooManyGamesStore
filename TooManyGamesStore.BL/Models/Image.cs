using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooManyGamesStore.BL.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageFileName { get; set; }
        public byte[] ImageData { get; set; }
    }
}
