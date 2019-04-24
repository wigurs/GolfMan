
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.App.Assist.AssistStructure;

namespace GolfMan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GolfPage : ContentPage
    {
        public GolfPage()
        {
            InitializeComponent();

            BindingContext = new ScoreViewModel();
            Title = "GolfPage";
        }
    }
}