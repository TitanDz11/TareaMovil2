using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ethan
{
    public class Configuration:IConfiguration
    {
        private string DIRECTORIO;
        private ISQLitePlatform PLATAFORMA;
        public string directorio
        {
            get 
            {
                if(string.IsNullOrEmpty(DIRECTORIO))
                {
                    DIRECTORIO = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return DIRECTORIO;
            }
        }
        public ISQLitePlatform plataforma
        {
            get
            {
                
                return PLATAFORMA;
            }
        }

        ISQLitePlatform IConfiguration.plataforma => throw new NotImplementedException();
    }
}
