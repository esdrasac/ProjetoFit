using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjetoFitness.Pages.Login;
namespace ProjetoFitness {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            CarouselLogin aux = new CarouselLogin();
            aux.SelectedItem = aux.Children[1];
            MainPage = aux;

#if DEBUG
            HotReloader.Current.Run(this);
#endif
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
