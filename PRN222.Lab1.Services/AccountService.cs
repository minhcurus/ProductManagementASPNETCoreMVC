using PRN222.Lab1.Repositories;
using PRN222.Lab1.Repositories.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN222.Lab1.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository iAccountRepository;

        public AccountService()
        {
            iAccountRepository = new AccountRepository();
        }
        public AccountMember GetAccountById(string accountId)
        {
            return iAccountRepository.GetAccountById(accountId);
        }
    }
}
