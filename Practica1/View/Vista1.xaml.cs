using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista1 : ContentPage
    {
        public Vista1()
        {
            InitializeComponent();
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista2());
        }
    }
}