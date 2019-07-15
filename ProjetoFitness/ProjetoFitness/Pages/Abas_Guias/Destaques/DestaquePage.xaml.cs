using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoFitness.Pages.Abas_Guias.Destaques
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DestaquePage : ContentPage
    {
        public DestaquePage()
        {
            InitializeComponent();
        }
        public void ToCarrinho(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Pages.Abas_Guias.Carrinho.CarrinhoPage());
        }
    }
}