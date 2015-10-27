﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Model:INotifyPropertyChanged
    {
        private string _a;
        private string _lower;
        private string _upper;

        public string A
        {
            get { return _a; }
            set
            {
                _a = value;
                Upper = A.ToUpper();
                Lower = A.ToLower();
            }
        }

        public string Lower
        {
            get { return _lower; }
            set
            {
                if (value == _lower)
                    return;
                _lower = value;
                OnPropertyChanged();
            }
        }

        public string Upper
        {
            get { return _upper; }
            set
            {
                if (value == _upper) return;
                _upper = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}