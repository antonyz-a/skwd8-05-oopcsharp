﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Class5.DomainServiceClasses.Domain
{
	// User -> multile habits -> mutliple records
	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
