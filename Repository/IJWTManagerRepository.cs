﻿using jwtdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace jwtdemo.Repository
{
    public interface IJWTManagerRepository
    {
       Tokens Authenticate(Users users);
       
    }
}
