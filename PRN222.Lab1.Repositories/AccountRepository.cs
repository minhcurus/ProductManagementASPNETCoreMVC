using PRN222.Lab1.Repositories.BusinessObjects;
using PRN222.Lab1.Repositories.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN222.Lab1.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(string accountId) => AccountDAO.GetAccountById(accountId);

    }
}
