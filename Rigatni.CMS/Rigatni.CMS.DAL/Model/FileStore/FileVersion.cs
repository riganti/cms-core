using Riganti.Utils.Infrastructure.Core;
using System;

namespace Rigatni.CMS.DAL.Model.FileStore
{
    public class FileVersion : IEntity<int>
    {
        public int Id { get; set; }
        public FileStoreItem File { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}