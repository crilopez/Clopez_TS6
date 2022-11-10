using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXACristianLopez.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pag1 : ContentPage
    {

        private const string Url = "http://192.168.100.15/galenosys/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<EXACristianLopez.Datos> _post;


        public Pag1(string param1)
        {
            InitializeComponent();
            lblParametros.Text = "Bienvenido: " + param1;
            get();
        }


        public async void get()
        {
            var content = await client.GetStringAsync(Url);
            List<EXACristianLopez.Datos> post = JsonConvert.DeserializeObject<List<EXACristianLopez.Datos>>(content);
            _post = new ObservableCollection<EXACristianLopez.Datos>(post);

            ListViewUsuarios.ItemsSource = _post;

        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new Pag2());

            await Navigation.PushAsync(new Pag2());

        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}