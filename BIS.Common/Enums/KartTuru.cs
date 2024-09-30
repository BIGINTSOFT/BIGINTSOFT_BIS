using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.Common.Enums
{
    public enum KartTuru : byte
    {
        [Description("User Kartı")]
        User = 1,
        [Description("Makine Kartı")]
        Makine = 2,
        [Description("Filtre Kartı")]
        Filtre = 99,
    }
}
