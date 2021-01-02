using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zonama.DTO;

namespace Zonama.Interface
{
    public interface IRepository
    {
        LoginDTO Authentifier(string email, string password);
    }
}