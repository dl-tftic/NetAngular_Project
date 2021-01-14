using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Files
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string FileExension { get; set; }
        public byte[] FileByte { get; set; }
        public long FileSize { get; set; }

#nullable enable
        public string? FileLinkId { get; set; }
        public string? Description { get; set; }
#nullable disable

        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
    }
}
