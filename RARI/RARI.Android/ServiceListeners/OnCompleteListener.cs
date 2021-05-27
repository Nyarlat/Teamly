using Android.App;
using Android.Content;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RARI.Droid.ServiceListeners
{
    public class OnCompleteListener : Java.Lang.Object, IOnCompleteListener
    {
        private TaskCompletionSource<Person> _tcs;

        public OnCompleteListener(TaskCompletionSource<Person> tcs)
        {
            _tcs = tcs;
        }

        public void OnComplete(Android.Gms.Tasks.Task task)
        {
            if (task.IsSuccessful)
            {
                var result = task.Result;
                if (result is DocumentSnapshot doc)
                {
                    var user = new Person();
                    user.Id = doc.Id;
                    user.FName = doc.GetString("FirstName");
                    user.SName = doc.GetString("SecondName");
                    user.Nick = doc.GetString("Nick");
                    user.City = doc.GetString("City");
                    user.Langs = doc.GetString("Langs");
                    _tcs.TrySetResult(user);
                    return;
                }
            }
            // что-то пошло не так...
            _tcs.TrySetResult(default(Person));
        }
    }
}