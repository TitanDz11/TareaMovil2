using Ethan.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ethan.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Persona : ContentPage
    {
        public Persona()
        {
            InitializeComponent();
            this.BindingContext = new VMPersona();
            btnVer.Clicked += BtnVer_Clicked;
        }

        private void BtnVer_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Listado());
        }
    }
}