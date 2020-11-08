using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers
{
    public class MarkerData
    {
        public string Owner { get; set; }
        public string DocId { get; set; }
        public string MarkerId { get; set; }
        public string MarkerType { get; set; }
        public MarkerLocation MarkerLoc { get; set; }
        public string ForeColor { get; set; }
        public string BackColor { get; set; }

    }
}
