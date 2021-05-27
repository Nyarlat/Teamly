using Firebase.Auth;
using Firebase.Firestore;
using RARI.Droid.ServiceListeners;
using RARI.Droid.Services;
using RARI.Services.Account;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidAcService))]
namespace RARI.Droid.Services
{
    public class AndroidAcService : IAccountService
    {
        public AndroidAcService()
        {
        }

        public Task<double> GetCurrentPayRateAsync()
        {
            return Task.FromResult(10d);
        }

        public Task<Person> GetUserAsync()
        {
            var tcs = new TaskCompletionSource<Person>();

            FirebaseFirestore.Instance
                .Collection("users")
                .Document(FirebaseAuth.Instance.CurrentUser.Uid)
                .Get()
                .AddOnCompleteListener(new OnCompleteListener(tcs));

            return tcs.Task;
        }

        public Task<bool> LoginAsync(string username, string password)
        {
            var tcs = new TaskCompletionSource<bool>();
            FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(username, password)
                .ContinueWith((task) => OnAuthCompleted(task, tcs));
            return tcs.Task;
        }

        private void OnAuthCompleted(Task task, TaskCompletionSource<bool> tcs)
        {
            if (task.IsCanceled || task.IsFaulted)
            {
                // что-то пошло не так...
                tcs.SetResult(false);
                return;
            }
            tcs.SetResult(true);
        }
    }
}