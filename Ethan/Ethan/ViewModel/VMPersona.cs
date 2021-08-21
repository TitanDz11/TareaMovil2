using Ethan.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ethan.ViewModel
{
    public class VMPersona:PersonaModel
    {
        private ICommand Guardar { get; set;}
        private ICommand Modificar { get; set; }
        private ICommand Eliminar { get; set; }
        private ICommand Nuevo { get; set; }

        public VMPersona()
        {
            Guardar = new Command(() =>
            {
                PersonaModel modelo = new PersonaModel()
                {
                    Descrip = Descrip,
                    Mont = Mont,
                    Fech = Fech,
                    Fot = Fot,
                    Puest = Puest
                };

                using (var contexto = new DataContext())
                {
                    contexto.Insertar(modelo);
                }
            });


            Modificar = new Command(() =>
            {
                PersonaModel modelo = new PersonaModel()
                {
                    IdPag = IdPag,
                    Descrip = Descrip,
                    Mont = Mont,
                    Fech = Fech,
                    Fot = Fot,
                    Puest = Puest
                };

                using (var contexto = new DataContext())
                {
                    contexto.Actualizar(modelo);
                }
            });


            Eliminar = new Command(() =>
            {
                PersonaModel modelo = new PersonaModel()
                {
                    IdPag = IdPag,
                    Descrip = Descrip,
                    Mont = Mont,
                    Fech = Fech,
                    Fot = Fot,
                    Puest = Puest
                };

                using (var contexto = new DataContext())
                {
                    contexto.Actualizar(modelo);
                }
            });

            Nuevo = new Command(() =>
            {

                Descrip = string.Empty;
                Fech = string.Empty;
                Fot = string.Empty;
                Puest = string.Empty;
            });
        }
    }
}
