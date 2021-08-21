using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace Ethan.Model
{
    public class PersonaModel:INotifyPropertyChanged
    { 
        private int IdPago;
        private string Nombre;
        private string Apellido;
        private int Edad;
        private string Direccion;
        private string Puesto;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad) 
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey,AutoIncrement]
        public int IdPag
        {
            get { return IdPago; }
            set
            {
                if(IdPag !=value)
                {
                    IdPag = value;
                    OnPropertyChanged("IdPag");
                }
            }
        }
        public string Descrip
        {
            get { return Nombre; }
            set
            {
                if (Descrip != value)
                {
                    Descrip = value;
                    OnPropertyChanged("Descrip");
                }
            }
        }
        public string Fech
        {
            get { return Apellido; }
            set
            {
                if (Fech != value)
                {
                    Fech = value;
                    OnPropertyChanged("Fech");
                }
            }
        }
        public int Mont
        {
            get { return Edad; }
            set
            {
                if (Mont != value)
                {
                    Mont = value;
                    OnPropertyChanged("Mont");
                }
            }
        }
        public string Fot
        {
            get { return Direccion; }
            set
            {
                if (Fot != value)
                {
                    Fot = value;
                    OnPropertyChanged("Fot");
                }
            }
        }
        public string Puest
        {
            get { return Puesto; }
            set
            {
                if (Puest != value)
                {
                    Puest = value;
                    OnPropertyChanged("Puest");
                }
            }
        }


    }
}
