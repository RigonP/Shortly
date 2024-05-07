using Shortly.Client.Helpers.Validators;
using System.ComponentModel.DataAnnotations;

namespace Shortly.Client.Data.ViewModels
{
	public class ConfirmEmailLoginVM
	{
		[Required(ErrorMessage = "Email address is required")]
		[CostumEmailValidator(ErrorMessage = "Email address is not valid (costum)")]
		public string EmailAddress { get; set; }
	}
}
