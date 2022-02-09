using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._3
{
    [Serializable]
    internal class Explorer
    {
        public int ArtifactsDiscovered { get; set; }
        public string Name { get; set; }
        public string LastKnownLocation { get; set; }
    }
}
