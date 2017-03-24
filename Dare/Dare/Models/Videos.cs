using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dare.Models
{
    public class Videos
    {
        [Key]
        public int Id { get; set; }
        public byte[] imageData { get; set; }
        public int FileName { get; set; }
        [Required(ErrorMessage = "Please select a file")]
        public HttpPostedFileBase File { get; set; }
    }
}