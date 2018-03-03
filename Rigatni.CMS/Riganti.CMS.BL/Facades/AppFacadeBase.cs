using Riganti.Utils.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Riganti.CMS.BL.Facades
{
    public abstract class AppFacadeBase
    {
        public IUnitOfWorkProvider UnitOfWorkProvider { get; set; }

        public ILogger Log { get; set; }

    }

}
