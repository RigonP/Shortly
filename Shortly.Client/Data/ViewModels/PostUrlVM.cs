using System.ComponentModel.DataAnnotations;

namespace Shortly.Client.Data.ViewModels
{
	public class PostUrlVM
	{
		[Required(ErrorMessage = "URL is required")]
		[RegularExpression("^http(s)?://([\\w-]+.)+[\\w-]+(/[\\w-./?%&=])?$", ErrorMessage = "The value is not a valid URL")]
		public string Url { get; set; }
	}
}
