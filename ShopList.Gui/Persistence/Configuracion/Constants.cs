using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopList.Gui.Persistence.Configuracion
{
   public  static class Constants
    {
        public static string DataBasePath =>
            Path.Combine(
                FileSystem.AppDataDirectory, 
                DataBaseFileName
                );
        public const string DataBaseFileName = "ShopList.db3";
        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

    }
    
}

