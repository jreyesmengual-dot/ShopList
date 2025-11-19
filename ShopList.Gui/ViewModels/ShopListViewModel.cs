using ShopList.Gui.Models;
using System.Collections.ObjectModel;


namespace ShopList.Gui.ViewModels
{
    public class ShopListViewModel
    {
       public ObservableCollection<Item> Items { get; }
        public ShopListViewModel()
        {
            Items = new ObservableCollection<Item>();
            CargarDatos();
            
        }
        private void CargarDatos()
        {
         Items.Add(new Item()
            {
                Id = 1,
                Nombre = "leche",
                Cantidad = 2,
            });
            Items.Add(new Item()
            {
                Id = 2,
                Nombre = "pan bimbo zero",
                Cantidad = 1,
            });
            Items.Add(new Item()
            {
                Id = 3,
                Nombre = "jamon",
                Cantidad = 500,
            });

        }
    }
    
}
