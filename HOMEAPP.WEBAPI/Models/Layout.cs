using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NOTICEBOARD.WEBAPI.Models
{
    public class Layout
    {
        public List<SubCategory> subcategory { get; set; }
        public List<Category>   mainCategory { get; set; }
        public List<ScreenSaver> screenSaverVedio { get; set; }

    }
}