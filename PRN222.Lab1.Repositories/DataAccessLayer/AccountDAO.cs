using PRN222.Lab1.Repositories.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN222.Lab1.Repositories.DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountId)
        {
            using var db = new MyStoreContext();
            return db.AccountMembers.FirstOrDefault(c=>c.MemberId.Equals(accountId));
        }
    }
}
