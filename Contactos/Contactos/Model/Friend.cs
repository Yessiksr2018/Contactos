using Contactos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contactos.Model
{
    public class Friend : Notificable
    {
        public int ID { get; set; }
        private string nombre;
        private string telefono;
        private string correo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
