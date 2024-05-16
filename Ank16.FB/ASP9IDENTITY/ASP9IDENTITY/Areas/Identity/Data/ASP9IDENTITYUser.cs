using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASP9IDENTITY.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ASP9IDENTITYUser class
public class ASP9IDENTITYUser : IdentityUser
{
    public string Name { get; set; }
    public string Surname {  get; set; }
    //KULLLANICIYA EKLEMEK İSTEDİĞİMİZ EXTRA PROPLARI BURAYA YAZACAĞIZ
}

