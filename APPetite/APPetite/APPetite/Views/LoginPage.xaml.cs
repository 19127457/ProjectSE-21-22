using APPetite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPetite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private async void Sign_in_clicked(object sender, EventArgs e)
        {

        }

        private async void Sign_up_clicked(object sender, EventArgs e)
        {

        }

        private async void Forgot_password_clicked(object sender, EventArgs e)
        {

        }
    }
}