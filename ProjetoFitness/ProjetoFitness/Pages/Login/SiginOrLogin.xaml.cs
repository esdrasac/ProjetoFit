using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFitness.Pages.Login {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SiginOrLogin : ContentPage {
        public SiginOrLogin() {
            InitializeComponent();
        }

        private void ToSingupPage(object sender, EventArgs args)
        {
            var carousel = ((CarouselPage)App.Current.MainPage);
            carousel.CurrentPage = carousel.Children[0];

        }
        private void ToLoginPage(object sender, EventArgs args)
        {
            var carousel = ((CarouselPage)App.Current.MainPage);
            carousel.CurrentPage = carousel.Children[2];
        }
    }
}