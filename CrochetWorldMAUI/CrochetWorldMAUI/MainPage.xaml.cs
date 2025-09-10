using System.Threading.Tasks;

namespace CrochetWorldMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGoToDetailsClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CrochetNote());
        }
    }

}
