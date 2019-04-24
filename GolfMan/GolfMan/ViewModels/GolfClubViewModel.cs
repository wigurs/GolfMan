using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace GolfMan.ViewModels
{
    public class GolfClubViewModel : BaseViewModel
    {
        public GolfClubViewModel()
        {
            Title = "GolfClub";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://tranasgk.se")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
