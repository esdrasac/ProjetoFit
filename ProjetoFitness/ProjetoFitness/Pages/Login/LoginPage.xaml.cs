using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransparentNavBarXForms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFitness.Pages.Login {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage {
        public LoginPage() {
            InitializeComponent();

        }
        private void CadastrarCliente(object sender, EventArgs args)
        {
            App.Current.MainPage = new CustomNavigationPage(new Abas_Guias.Abas());

        }
    }
}