using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIAUTH.Models
{
    public class UDSSD
    {
        public List<ssdclass> SSD { get; set; }
        public int totalRows { get; set; }
        public int currentPage { get; set; }
    }

    public class ssdclass
    {
        public int indexCount { get; set; }
        public System.Guid ID { get; set; }
        public string POST_NAME { get; set; }
        public string POST_CONTENT { get; set; }
        public string POST_TYPE { get; set; }
        public Nullable<System.DateTime> DATE_ENTERED { get; set; }
    }
}