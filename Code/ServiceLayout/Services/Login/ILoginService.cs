using Microsoft.AspNetCore.Identity;
using ModelLayout.Models.User;
using ServiceLayout.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Login
{
    public interface ILoginService : IDbService
    {
        bool Login(User user);
    }
}
