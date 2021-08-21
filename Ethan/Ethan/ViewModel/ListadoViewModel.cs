using Ethan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ethan.ViewModel
{
    public class ListadoViewModel:PersonaModel
    {
        private ObservableCollection<PersonaModel> ListadoPersonas;

        public ObservableCollection<PersonaModel> ListadoPersonas1 
        { 
            get
            {
                if(ListadoPersonas==null)
                {
                    LlenarPersonas();
                }
                return ListadoPersonas;
            }
            set
            {
                ListadoPersonas = value;
            }
        }
        public void LlenarPersonas()
        {
            using(var contexto=new DataContext())
            {
                ObservableCollection<PersonaModel> modelo = new ObservableCollection<PersonaModel>(contexto.Consultar());
                ListadoPersonas = modelo;
            }
            
        }
    }
}
