using System;
using System.Collections.Generic;
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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("usr_id", txtcodigo.Text);
                parametros.Add("usr_login", "login");
                parametros.Add("usr_nombre", txtnombre.Text);
                parametros.Add("usr_apellido", txtapellido.Text);
                parametros.Add("usr_pass", "123");
                parametros.Add("usr_rol", "estudiante");
                parametros.Add("usr_estado", "activo");

                var Urlbase = "http://192.168.100.15/galenosys/post.php?"; // usr_id=1&usr_rol=administrador";

                var param1 = "usr_id=" + txtcodigo.Text;
                var param2 = "&usr_login=" + "login2";
                var param3 = "&usr_nombre=" + txtnombre.Text;
                var param4 = "&usr_apellido=" + txtapellido.Text;
                var param5 = "&usr_pass=" + "1232";
                var param6 = "&usr_rol=" + "estudiante2";
                var param7 = "&usr_estado=" + "activo2";

                var paramtot = param1 + param2 + param3 + param4 + param5 + param6 + param7;

                var Urlpost = Urlbase + paramtot; 
                
                var response = await httpClient.PutAsync(Urlpost, null);

                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Información", "OK Registro Actualizado", "Cerrar");
                }
                else
                {
                    DisplayAlert("Error", "Problemas al actualizar el registro.", "Cerrar");
                }
            }

        }

        private async void btnReg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pag1(""));
        }
    }
}