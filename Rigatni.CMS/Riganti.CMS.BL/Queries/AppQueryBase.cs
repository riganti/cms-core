using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.EntityFrameworkCore;
using Rigatni.CMS.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Riganti.CMS.BL.Queries
{
    public abstract class AppQueryBase<TResult> : EntityFrameworkQuery<TResult>
    {
        public AppQueryBase(IUnitOfWorkProvider provider) : base(provider)
        {
        }

        protected new CmsDbContext Context => (CmsDbContext)base.Context;
    }
}
