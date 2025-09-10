using System.Threading.Tasks;

namespace CrochetWorldMAUI
{
    public partial class CrochetNote : ContentPage
    {

        public CrochetNote()
        {
            InitializeComponent();
        }

        private async void Return(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            ReadOnlyEntry.Text = CrochetStitches.Text;
        }
    }

}
