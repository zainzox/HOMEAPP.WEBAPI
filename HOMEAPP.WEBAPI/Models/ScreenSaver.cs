using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NOTICEBOARD.WEBAPI.Models
{
    public class ScreenSaver
    {
        public int categoryId { get; set; }
        public int mediaId { get; set; }
        public int activeAsScreenSaver { get; set; }
        public string subCategoryDescription { get; set; }
    }
}