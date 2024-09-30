using BIS.Entity.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIS.BLL.Interfaces
{
    public interface IBaseCommonService
    {
        bool Delete(BaseEntity entity);
    }
}
