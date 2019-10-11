using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}