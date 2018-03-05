using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.Rating;
using System.Collections.Generic;

namespace Rigatni.CMS.DAL.Model.FileStore
{
    public class FileStoreItem : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFolder { get; set; }
        public RatedItem Rating { get; set; }
        public FileData FileData { get; set; }
    }
}