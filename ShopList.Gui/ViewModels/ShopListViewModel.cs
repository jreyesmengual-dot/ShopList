using ShopList.Gui.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace ShopList.Gui.ViewModels
{
    public class ShopListViewModel : INotifyPropertyChanged
    {
       
        private string _nombredelarticulo = string.Empty;
        private int _cantidadacomprar = 1;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Item> Items { get; }

        public string NombredelArticulo
        {
            get => _nombredelarticulo;
            set
            {
                if (_nombredelarticulo != value)
                {
                    _nombredelarticulo = value;
                    OnPropertyChanged(nameof(NombredelArticulo));
                }

            }
        }

        public int CantidadAComprar
        {
            get => _cantidadacomprar;
            set
            {
                if (value != _cantidadacomprar)
                {
                    _cantidadacomprar = value;
                    OnPropertyChanged(nameof(CantidadAComprar));
                }
            }
        }
       
        public ICommand AgregarShopListItemCommand
        {
            get;
            private set;
        }
        public ShopListViewModel()
        {
            Items = new ObservableCollection<Item>();
            CargarDatos();
            AgregarShopListItemCommand = new Command(AgregarShopListItem);
            
        }
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
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    
}
