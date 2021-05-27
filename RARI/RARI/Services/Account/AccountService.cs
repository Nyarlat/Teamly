using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RARI.Services.Account
{
    public class AccountService : IAccountService
    {
        public Task<double> GetCurrentPayRateAsync()
        {
            return Task.FromResult(10.0);
        }

        public Task<Person> GetUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return Task.FromResult(false);
            }
            return Task.Delay(1000).ContinueWith((task) => true);
        }
    }
}
