using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFitness.Pages.Abas_Guias.Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var listaImagens = new List<string>
            {
                "Pinterest1.jfif",
                "Pinterest2.jfif",
                "Pinterest3.jfif"
            };
            ImageCarousel.ItemsSource = listaImagens;
        }
        public void ToCarrinho(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Pages.Abas_Guias.Carrinho.CarrinhoPage());
        }
    }
}