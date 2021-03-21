using System;
using System.Collections.Generic;
using System.Text;

namespace OpenDax_Desktop.ViewModels
{
    public class SplashScreenVM
    {
        private string _action = "Init";


        public string Action
        {
            get => _action;
            private set => _action = value;
        }
    }
}
