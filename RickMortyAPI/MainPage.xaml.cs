using RickMortyAPI.Servicios; 
namespace RickMortyAPI
{
    public partial class MainPage : ContentPage
    {

        private readonly IRickAndMortyServices _rickAndMortyServices;

        public MainPage(IRickAndMortyServices services)
        {
            InitializeComponent();
            _rickAndMortyServices = services;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Loading.IsVisible = true;
            var data = await _rickAndMortyServices.Obtener();
            listviewPersonajes.ItemsSource = data;

            Loading.IsVisible = false;
        }
    }

}
