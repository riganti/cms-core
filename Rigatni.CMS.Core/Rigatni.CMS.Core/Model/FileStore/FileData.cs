using Riganti.Utils.Infrastructure.Core;

namespace Rigatni.CMS.Core.Model.FileStore
{
    public class FileData : IEntity<int>
    {
        public int Id { get; set; }
        public byte[] FileDataContent { get; set; }
        public FileVersion FileVersion { get; set; }
    }
}