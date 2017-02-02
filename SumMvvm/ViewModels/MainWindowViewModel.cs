using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace SumMvvm.ViewModels
{
    public class MainWindowViewModel :BindableBase
    {
        private int _x = 1;
        private int _y = 2;
        private int _z = 3;
        // Hier Mit Prism 
        public int X
        {
            get { return _x; }
            set { SetProperty(ref _x, value); }
        }

        public int Y
        {
            get { return _y; }
            set { SetProperty(ref _y, value); }
        }

       

        public int Z
        {
            get { return _z; }
            set{SetProperty(ref _z, value);}
        }


        public ICommand SumCommand { get; private set; }

        public MainWindowViewModel()
        {
            SumCommand = new DelegateCommand(OnSum);
        }

        private void OnSum()
        {
            Z = X + Y;
        }

    }
}
