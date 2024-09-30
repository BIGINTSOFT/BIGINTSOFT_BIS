using BIS.BLL.Base;
using BIS.BLL.Interfaces;
using BIS.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.BLL.General
{
    public class FiltreService : BaseGenelService<Filtre>, IBaseCommonService
    {
        public FiltreService() : base(KartTuru.Filtre) { }

        public FiltreService(Control ctrl) : base(ctrl, KartTuru.Filtre) { }



    }
}
