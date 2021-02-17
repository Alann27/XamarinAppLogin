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

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entEmail.Text) && !string.IsNullOrEmpty(entPassword.Text))
            {

                await DisplayAlert("INTEC App", $"Bienvenido, {entEmail.Text}!", "Aceptar");

                await Navigation.PushModalAsync(new HomePage());


            }
            else
            {
                await DisplayAlert("INTEC App", "Campo Email y/o contraseña no puede estar vacío", "Aceptar");
            }
        }

        private void Registro_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}