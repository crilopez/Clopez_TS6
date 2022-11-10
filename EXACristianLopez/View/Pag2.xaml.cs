using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXACristianLopez.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pag2 : ContentPage
    {
        public Pag2()
        {
            InitializeComponent();
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PopAsync();
            await Navigation.PushAsync(new Pag1(""));
        }

        private void BtnGrabar_Clicked(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            try
            {
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("usr_id", txtcodigo.Text);
                parametros.Add("usr_login", "login");
                parametros.Add("usr_nombre", txtnombre.Text);
                parametros.Add("usr_apellido", txtapellido.Text);
                parametros.Add("usr_pass", "123");
                parametros.Add("usr_rol", "estudiante");
                parametros.Add("usr_estado", "activo");

                client.UploadValues("http://192.168.100.15/galenosys/post.php", "POST", parametros);

                    DisplayAlert("Información", "OK Nuevo Registro con éxito", "Cerrar");

            }

            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
    }
}