using System;
using System.ComponentModel;

namespace SaladilloWare.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private String usuario, password;

        public event PropertyChangedEventHandler PropertyChanged;

        public String Usuario
        {
            set
            {

            }
            get
            {
                return "";
            }
        }
    }
}
