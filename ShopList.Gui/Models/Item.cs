using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopList.Gui.Models
{
    internal class Item
    {
        public int Id { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public bool comprado { get; set; } = false;

        public override string ToString()
        {
            return $"{Nombre} ({Cantidad})";
        }
    }
}
