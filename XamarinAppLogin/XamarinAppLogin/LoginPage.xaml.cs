using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : TabbedPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {

                await DisplayAlert("INTEC App", $"Bienvenido, {emailEntry.Text}!", "Aceptar");

                await Navigation.PushModalAsync(new HomePage());


            }
            else
            {
                await DisplayAlert("INTEC App", "Campo Email y/o contraseña no puede estar vacío", "Aceptar");
            }
        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}