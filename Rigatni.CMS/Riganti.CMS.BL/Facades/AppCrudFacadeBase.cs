using Riganti.Utils.Infrastructure.Core;
using Riganti.Utils.Infrastructure.Services.Facades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Riganti.CMS.BL.Facades
{

    public abstract class AppCrudFacadeBase<TEntity, TKey, TListDTO, TDetailDTO> : CrudFacadeBase<TEntity, TKey, TListDTO, TDetailDTO> where TEntity : IEntity<TKey> where TDetailDTO : IEntity<TKey>
    {

        public AppCrudFacadeBase(IQuery<TListDTO> query, IRepository<TEntity, TKey> repository, IEntityDTOMapper<TEntity, TDetailDTO> mapper) : base(query, repository, mapper)
        {
        }

        public ILogger Log { get; set; }

    }

    public abstract class AppCrudFacadeBase<TEntity, TKey, TListDTO, TDetailDTO, TFilterDTO> : FilteredCrudFacadeBase<TEntity, TKey, TListDTO, TDetailDTO, TFilterDTO> where TEntity : IEntity<TKey> where TDetailDTO : IEntity<TKey>
    {

        public AppCrudFacadeBase(IFilteredQuery<TListDTO, TFilterDTO> query, IRepository<TEntity, TKey> repository, IEntityDTOMapper<TEntity, TDetailDTO> mapper) : base(query, repository, mapper)
        {
        }

        public ILogger Log { get; set; }


    }

}
