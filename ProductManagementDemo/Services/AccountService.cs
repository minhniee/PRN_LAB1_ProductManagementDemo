using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountService;
        public AccountService() => _accountService = new AccountRepository();
        public AccountMember GetAccountById(string accountID)
        {
            return _accountService.GetAccountById(accountID);
        }
        

    }
}
