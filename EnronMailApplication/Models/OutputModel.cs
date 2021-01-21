using System;
using System.Collections.Generic;

namespace EnronMailApplication.Models

{
        public partial class OutputModel
    {
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
        public string Body { get; set; }
    }
}
