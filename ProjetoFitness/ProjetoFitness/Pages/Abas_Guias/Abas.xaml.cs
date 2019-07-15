using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using TransparentNavBarXForms;


namespace ProjetoFitness.Pages.Abas_Guias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : Xamarin.Forms.TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetElevation(50);
            this.SelectedTabColor = Color.FromHex("#000000");
            
            //string cor = "#121212";
            //BarBackgroundColor = Color.FromHex("#212121");
            //BarTextColor = Color.FromHex("#808184");

            Children.Add(new CustomNavigationPage(new Pages.Abas_Guias.Inicio.HomePage()) { Title="Início", IconImageSource = "Inicio.png", });
            Children.Add(new CustomNavigationPage(new Pages.Abas_Guias.Destaques.DestaquePage()) { Title = "Destaques", IconImageSource = "Destaque.png" });
            Children.Add(new CustomNavigationPage(new Pages.Abas_Guias.Pesquisar.SearchPage()) { Title = "Buscar", IconImageSource = "Buscar.png" });
            Children.Add(new CustomNavigationPage(new Pages.Abas_Guias.Compras.ShopPage()) { Title = "Minhas Compras", IconImageSource = "Compras.png" });
            Children.Add(new CustomNavigationPage(new Pages.Abas_Guias.Conta.AccountPage()) { Title = "Perfil", IconImageSource = "Conta.png" });
        }
    }
}