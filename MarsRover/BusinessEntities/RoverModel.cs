using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.BusinessEntities
{
    public class RoverModel
    {
        public bool Next { get; set; }
        public int Position { get; set; }
        public int vDist { get; set; }
        public int hDist { get; set; }
        public string Direction { get; set; }
    }
}
