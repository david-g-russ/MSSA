using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioWebsite.Models
{
    public class Project
    {
        [Display(Name = "Project ID")]
        [Required(ErrorMessage = "You must create a Project ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "You must choose a Project Name")]
        [MaxLength(50, ErrorMessage = "Project Name must be less than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Project Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Portfolio Type")]
        [Required(ErrorMessage = "You must select a project type")]
        public PortfolioType PortfolioType { get; set; }

        [Display(Name = "First Project Image")]
        public string ImageName1 { get; set; }

        [Display(Name = "Second Project Image")]
        public string ImageName2 { get; set; }

        [Display(Name = "Third Project Image")]
        public string ImageName3 { get; set; }

        [Display(Name = "Video URL")]
        [DataType(DataType.Url)]
        public string VideoUrl { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime ProjectDate { get; set; }

        [Display(Name = "User Interface")]
        public string UserInterface { get; set; }

        [Display(Name = "GitHub URL")]
        [DataType(DataType.Url)]
        public string GitHubUrl { get; set; }

        [Display(Name = "C#")]
        public bool HasCs { get; set; }

        [Display(Name = "JavaScript")]
        public bool HasJs { get; set; }

        [Display(Name = "CSS3")]
        public bool HasCss { get; set; }

        [Display(Name = "HTML5")]
        public bool HasHtml { get; set; }

        [Display(Name = "ASP.NET")]
        public bool HasAsp { get; set; }

        [Display(Name = "SQL")]
        public bool HasSql { get; set; }
    }

    public enum PortfolioType
    {
        Full,
        Video,
        Picture
    }
}