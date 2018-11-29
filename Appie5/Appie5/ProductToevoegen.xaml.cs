using Appie5.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appie5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductToevoegen : ContentPage
    {
        public Product Product { get; set; }

        public ProductToevoegen()
        {
            InitializeComponent();
            Product = new Product() { Categorie = new Categorie() };
            BindingContext = this;
        }

        public void Opslaan_Clicked(object sender, EventArgs e)
        {
            // Opslaan
            Product.ToString();
        }
    }
}