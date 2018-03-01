using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.Rating;
using System.Collections.Generic;

namespace Rigatni.CMS.Core.Model.FileStore
{
    public class FileStoreItem : IEntity<int>
    {
        public int Id { get; set; }
        public List<FileStoreItem> ChildFileStoreItems { get; set; }
        public RatedItem Rating { get; set; }
        public FileData FileData { get; set; }

    }
}