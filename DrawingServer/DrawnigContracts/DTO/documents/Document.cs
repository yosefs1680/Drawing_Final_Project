using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documents
{
    public class Document
    {
        public string Owner { get; set; }
        public string DocId { get; set; }
        public string DocUrl { get; set; }
        public string DocName { get; set; }
    }
}
