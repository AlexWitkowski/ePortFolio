using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPortfolioAlexWitkowski.Models
{
    public class Project
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank")]
        [Display(Name = "File Path")]
        [MaxLength(250)]
        public string FilePath { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank")]
        [Display(Name = "ThumbNail")]
        [MaxLength(250)]
        public string ThumbNail { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank")]
        [Display(Name = "File Type")]
        public int FileTypeID { get; set; }

        [Required(ErrorMessage = "You cannot leave this field blank")]
        [Display(Name = "Description")]
        public string Desc { get; set; }

        public virtual FileType FileType { get; set; }
    }
}