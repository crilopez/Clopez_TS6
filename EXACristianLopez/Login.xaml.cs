using EXACristianLopez.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXACristianLopez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "22";
            string contrasena = "22";
            
            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;

            if (usuario == tUsuario & contrasena == tContrasena)
            {
                //DisplayAlert("Alerta", "OK USUARIO VALIDO", "Cerrar");
                
                var mensajever = "OK USUARIO VALIDO";
                DependencyService.Get<MensajeToast>().LongAlert(mensajever);

                await Navigation.PushAsync(new Pag1(usuario));

            }
            else
            {
                DisplayAlert("Alerta", "ERROR. USUARIO NO EXISTE", "Cerrar");
            }

        }
    }
}