using Riganti.Utils.Infrastructure.Core;

namespace Rigatni.CMS.Core.Model.FileStore
{
    public class FileVersion : IEntity<int>
    {
        public int Id { get; set; }
        public FileStoreItem File { get; set; }
    }
}