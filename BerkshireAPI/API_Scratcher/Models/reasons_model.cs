using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Scratcher.Models
{
    public class reasons_list
    {
        public int id { get; set; }
        public string reason_Name { get; set; }
    }
    public class reasons_description
    {
        public int id { get; set; }
        public string reason_Description { get; set; }
    }
}