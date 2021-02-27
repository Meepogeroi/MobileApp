using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Class;

namespace MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        listUser Users;
        public AuthPage()
        {
            InitializeComponent();
            Users = new listUser();
        }

        private void AuthButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                User usr = Users.list.Where((User element) => element.UserName == LoginField.Text && element.UserPassword == PasswordField.Text).FirstOrDefault();
                this.Navigation.PushAsync(new UserPage(usr));
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void RegButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}