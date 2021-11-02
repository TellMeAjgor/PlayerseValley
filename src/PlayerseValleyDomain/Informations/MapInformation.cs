using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerseValleyDomain.Informations
{
    public class MapInformation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LevelRange { get; set; }
        public int LevelToEnter { get; set; }
    }
}
