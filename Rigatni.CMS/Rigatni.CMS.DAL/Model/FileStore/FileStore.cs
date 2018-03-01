using Riganti.Utils.Infrastructure.Core;
using System.Collections.Generic;

namespace Rigatni.CMS.DAL.Model.FileStore
{
    public class FileStore : IEntity<int>
    {
        public int Id { get; set; }
        public List<FileStoreItem> FileStoreItems { get; set; } = new List<FileStoreItem>();
        public string Name { get; set; }

    }
}