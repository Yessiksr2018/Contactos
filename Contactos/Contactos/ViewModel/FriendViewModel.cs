using Contactos.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Contactos.ViewModel
{
    public class FriendViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public Boolean IsEnabled { get; set; }
        public Friend FiendModel { get; set; }



    }
}
