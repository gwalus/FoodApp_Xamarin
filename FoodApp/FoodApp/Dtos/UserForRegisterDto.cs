﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Dtos
{
    public class UserForRegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
