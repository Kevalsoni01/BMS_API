﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BudgetManagement.Models.Utility
{
    public partial class ModelUpdateCredential
    {
        public string Password { get; set; }
        public string OldPassword { get; set; }
    }
}
