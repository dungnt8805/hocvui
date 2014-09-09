using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;
using System.Web;

namespace SocialWebApp.Models
{
    public class EntryModel
    {
        [Required]
        [StringLength(255, ErrorMessage = "Tiêu đề phải có ít nhất {2} kí tự", MinimumLength = 10)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
    }
}