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

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailEntry.Text) && !string.IsNullOrEmpty(nameEntry.Text) &&
                !string.IsNullOrEmpty(passwordEntry.Text) && !string.IsNullOrEmpty(confirmPasswordEntry.Text))
            {
                if (passwordEntry.Text == confirmPasswordEntry.Text)
                {
                    await DisplayAlert("Register", $"Bienvenido, {nameEntry.Text}!","OK");

                    await Navigation.PushModalAsync(new HomePage());
                }
                else
                {
                    await DisplayAlert("Error", "Las contraseñas no coinciden, favor introducirlas nuevamente","OK");

                    passwordEntry.Text = "";
                    confirmPasswordEntry.Text = "";
                    passwordEntry.Focus();
                }
            }
            else
            {
               await DisplayAlert("Error","Faltan campos por llenar, favor verifique e intente de nuevo", "OK");
            }
        }
    }
}