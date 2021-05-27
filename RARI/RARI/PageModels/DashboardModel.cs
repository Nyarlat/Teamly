using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RARI.PageModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RARI.PageModels
{
    public class DashboardModel : PageModelBase
    {

        private MessengerPageModel _messengerPM;
        public MessengerPageModel MessengerPageModel
        {
            get => _messengerPM;
            set => SetProperty(ref _messengerPM, value);
        }

        private PersonProfilePageModel _personprofilePM;
        public PersonProfilePageModel PersonProfilePageModel
        {
            get => _personprofilePM;
            set => SetProperty(ref _personprofilePM, value);
        }

        private TeamProfilePageModel _teamprofilePM;
        public TeamProfilePageModel TeamProfilePageModel
        {
            get => _teamprofilePM;
            set => SetProperty(ref _teamprofilePM, value);
        }

        public DashboardModel(MessengerPageModel messengerPM,
            PersonProfilePageModel personprofilePM,
            TeamProfilePageModel teamprofilePM)
        {
            MessengerPageModel = messengerPM;
            PersonProfilePageModel = personprofilePM;
            TeamProfilePageModel = teamprofilePM;
        }
        public override Task InitializeAsync(object navigationData)
        {
            return Task.WhenAny(base.InitializeAsync(navigationData),
                MessengerPageModel.InitializeAsync(null),
                PersonProfilePageModel.InitializeAsync(null),
                TeamProfilePageModel.InitializeAsync(null));
        }
    }
}
