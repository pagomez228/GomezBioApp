using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GomezBioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AboutMeNavigation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void SkillsNavigation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactMeNavigation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMePage());
        }
    }
}
