using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomezBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMePage : ContentPage
	{
		public ContactMePage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error", "Please enter your name", "Okay");
            }
            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please enter your email", "Okay");
            }
            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Please enter a message", "Okay");
            }
            else
            {
                DisplayAlert("Alert", "You're message was sent.", "Okay");
            }
            
        }
    }
}