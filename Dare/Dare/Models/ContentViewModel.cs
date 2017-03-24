using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dare.Models
{
    public class ContentViewModel
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Contents { get; set; }
        public byte[] Image { get; set; }
    }
}