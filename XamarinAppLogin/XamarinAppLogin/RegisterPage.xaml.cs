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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void BtnRegister_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entEmail.Text) && !string.IsNullOrEmpty(entName.Text) &&
                !string.IsNullOrEmpty(entPassword.Text) && !string.IsNullOrEmpty(entConfirmPassword.Text))
            {
                if (entPassword.Text == entConfirmPassword.Text)
                {
                    await DisplayAlert("Register", $"Bienvenido, {entName.Text}!","OK");

                    await Navigation.PushModalAsync(new HomePage());
                }
                else
                {
                    await DisplayAlert("Error", "Las contraseñas no coinciden, favor introducirlas nuevamente","OK");

                    entPassword.Text = "";
                    entConfirmPassword.Text = "";
                    entPassword.Focus();
                }
            }
            else
            {
               await DisplayAlert("Error","Faltan campos por llenar, favor verifique e intente de nuevo", "OK");
            }
        }
    }
}