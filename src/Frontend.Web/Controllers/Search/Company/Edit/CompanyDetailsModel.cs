using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DataAnnotationsExtensions;
using GwoDb;

public class CompanyDetailsModel : Controller
{
    public Message Message;

    [Required]
    [Display(Name = "Firmenname")]
    public string CompanyName { get; set; }

    [Required]
    [Display(Name = "Branche")]
    public string Industry { get; set; }

    [Required]
    [Display(Name = "Mitarbeiterzahl")]
    public string Size { get; set; }

    [Required]
    [Display(Name = "Webseite")]
    [Url(requireProtocol: false)]
    public string Url { get; set; }

    [Display(Name = "Ort")]
    public string Location { get; set; }

    [Display(Name = "Plz")]
    public string ZipCode { get; set; }

    [Required]
    [Display(Name = "E-Mail")]
    [Email]
    public string Email { get; set; }

    [Required]
    [Display(Name = "Bilanz für 2012")]
    public bool WelfareBalanceFor2012 { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
}
