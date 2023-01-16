﻿using System;
using System.Collections.Generic;

namespace LettercaixaAPI.Models;

public partial class Profile
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? ProfilePicture { get; set; }

    public DateTime Birth { get; set; }
}
