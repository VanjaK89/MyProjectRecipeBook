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

        private string _Farbe1;
        public string Farbe1 {
            get { return _Farbe1; }
            set { _Farbe1 = value; }

            }
        public ObservableCollection<string> FarbenListe { get; set; }
    }
}
