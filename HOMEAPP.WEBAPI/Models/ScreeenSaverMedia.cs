using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NOTICEBOARD.WEBAPI.Models
{
    public class ScreeenSaverMedia
    {
        public int mediaId { get; set;}
        public int categoryId { get; set;}
        public int layoutId { get; set;}
        public int isScreenSaver { get; set; }
        public int mediaTypeId { get; set;}
        public string subCategoryName { get; set; }


    }
}