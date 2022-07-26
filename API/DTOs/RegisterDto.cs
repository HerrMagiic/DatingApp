using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
	//The Dto class exists because when we want to register a user in the AccountController class the function register
	//needs to get an Object as the parameter to correctly get the data.
	//We can also now say Required to say that its required to parse a username and password
	public class RegisterDto
	{
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
