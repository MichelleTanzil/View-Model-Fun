using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using view_models_fun.Models;

namespace view_models_fun.Controllers
{
  public class UsersController : Controller
  {
    [HttpGet("/user")]
    public IActionResult UserDetail()
    {
      User someUser = new User()
      {
        FirstName = "Moose",
        LastName = "Philips"
      };
			
			return View(someUser);
    }
    [HttpGet("/users")]
		public IActionResult UsersDetail()
		{
			User someUser = new User()
      {
        FirstName = "Moose",
        LastName = "Philips"
      };
			User anotherUser = new User(){
				FirstName = "Sarah",
				LastName = " "
			};
			User anotherAnotherUser = new User(){
				FirstName = "Rene",
				LastName = "Ricky"
			};
			User lastUser = new User(){
				FirstName = "Barbarah",
				LastName = " "
			};

			List<User> viewUsers = new List<User>(){
				someUser, anotherUser, anotherAnotherUser, lastUser
			};
			return View(viewUsers);
		}

  }
}