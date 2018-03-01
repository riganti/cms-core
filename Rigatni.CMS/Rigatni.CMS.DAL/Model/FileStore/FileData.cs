using Riganti.Utils.Infrastructure.Core;
using Rigatni.CMS.DAL.Model.FileStore;

namespace Rigatni.CMS.DAL.Model.FileStore
{
    public class FileData : IEntity<int>
    {
        public int Id { get; set; }
        public byte[] FileDataContent { get; set; }
        public FileVersion FileVersion { get; set; }
    }
}