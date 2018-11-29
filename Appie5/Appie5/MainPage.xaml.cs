using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appie5.Models;
using Xamarin.Forms;

namespace Appie5
{
    public partial class MainPage : ContentPage
    {
        public Product Product { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Product = new Product()
                {Categorie = new Categorie(){Naam="Geen idee"}, 
                    Kleur = "Rood", 
                    Naam = "Weet ik niet", 
                    Prijs=99.99};

            BindingContext = this;
        }

        public async void Toevoegen_CLicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ProductToevoegen();
        }
    }
}
