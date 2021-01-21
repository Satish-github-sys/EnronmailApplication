using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SearchAPI.Domain.Entities
{
    public partial class Output 
    {
        [Key]
        public string Column1 { get; set; }
        public string UserName { get; set; }
        public string Folder { get; set; }
        public string Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }
        public string MimeVersion { get; set; }
        public string ContentType { get; set; }
        public string ContentTransferEncoding { get; set; }
        public string Bcc { get; set; }
        public string Xfrom { get; set; }
        public string Xto { get; set; }
        public string Xcc { get; set; }
        public string Xbcc { get; set; }
        public string Xfolder { get; set; }
        public string Xorigin { get; set; }
        public string XfileName { get; set; }
        public string Body { get; set; }
    }
}
