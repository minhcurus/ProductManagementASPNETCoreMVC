﻿using PRN222.Lab1.Repositories.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN222.Lab1.Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountById(string accountId);
    }
}
