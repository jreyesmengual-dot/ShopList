using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;
using System.Collections.ObjectModel;

using System.Runtime.CompilerServices;



namespace ShopList.Gui.ViewModels
{
    public partial class ShopListViewModel : ObservableObject 
    {
        [ObservableProperty]
        private string _nombredelarticulo = string.Empty;
        [ObservableProperty]    
        private int _cantidadacomprar = 1;

        

        public ObservableCollection<Item> Items { get; }

        //public string NombredelArticulo
        //{
        //    get => _nombredelarticulo;
        //    set
        //    {
        //        if (_nombredelarticulo != value)
        //        {
        //            _nombredelarticulo = value;
        //            OnPropertyChanged(nameof(NombredelArticulo));
        //        }

        //    }
        //}

        //public int CantidadAComprar
        //{
        //    get => _cantidadacomprar;
        //    set
        //    {
        //        if (value != _cantidadacomprar)
        //        {
        //            _cantidadacomprar = value;
        //            OnPropertyChanged(nameof(CantidadAComprar));
        //        }
        //    }
        //}

        //public ICommand AgregarShopListItemCommand
        //{
        //    get;
        //    private set;
        //}
        public ShopListViewModel()
        {
            Items = new ObservableCollection<Item>();
            CargarDatos();
            //AgregarShopListItemCommand = new Command(AgregarShopListItem);

        }
        [RelayCommand]
        public void AgregarShopListItem()
        {
            if(string.IsNullOrEmpty(NombredelArticulo)
               || CantidadAComprar <= 0)
            {
                return;
            }
               
            Random generador = new Random();
            var item = new Item
            {
                Id = generador.Next(),
                Nombre = NombredelArticulo,
                Cantidad = CantidadAComprar,
                comprado = false
            };
            Items.Add(item);
            NombredelArticulo = string.Empty;
            CantidadAComprar = 1;

        }
        [RelayCommand]
        public void EleminarShopListItem()
        {

        }

        private void CargarDatos()
        {
         Items.Add(new Item()
            {
                Id = 1,
                Nombre = "leche",
                Cantidad = 2,
                comprado = false,
            });
            Items.Add(new Item()
            {
                Id = 2,
                Nombre = "pan bimbo zero",
                Cantidad = 1,
                comprado = true,
            });
            Items.Add(new Item()
            {
                Id = 3,
                Nombre = "jamon",
                Cantidad = 500,
                comprado = false,
            });

           

        }
        
    }

    
}
