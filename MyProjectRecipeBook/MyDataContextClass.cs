using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectRecipeBook
{
    internal class MyDataContextClass
    {
        private string _Farbe;

        public string Farbe
        {
            get { return _Farbe; }
            set { _Farbe = value; }
        }

        public ObservableCollection<string> Farben { get; set; }
    }
}
