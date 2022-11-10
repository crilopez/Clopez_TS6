using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXACristianLopez.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private async void BtnDEL_Clicked(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync("http://192.168.100.15/galenosys/post.php?usr_id=" + txtdel.Text);

                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Alerta", "OK ELIMINADO", "Cerrar");
                }
                else
                {
                    DisplayAlert("Error","Problemas al eliminar registro.", "Cerrar");
                }
            }
        }

        private async void btnREG_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pag1(""));
        }
    }
}