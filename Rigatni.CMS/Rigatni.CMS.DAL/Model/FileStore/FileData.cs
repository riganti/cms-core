using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.FileStore;
using System.Collections.Generic;

namespace Rigatni.CMS.DAL.Model.FileStore
{
    public class FileData : IEntity<int>
    {
        public int Id { get; set; }
        public byte[] FileDataContent { get; set; }
        public List<FileVersion> FileVersion { get; set; }
    }
}