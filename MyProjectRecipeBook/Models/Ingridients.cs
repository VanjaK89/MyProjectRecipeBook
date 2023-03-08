using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectRecipeBook.Models
{
     class Ingridients : INotifyPropertyChanged

     {
        [Key]
        private int _Id;
        public int Id 
        { 
            get { return _Id;  }
            set { _Id = value;
                RaisePropertyChange("Id");
            }
        }
        private int _IngridientId;
        public int IngridientId
        {
            get { return _IngridientId; }
            set
            {
                _IngridientId = value;
                RaisePropertyChange("IngridientId");
            }
        }


        private string _Bezeichnung;

        public string Bezeichnung
        {
            get { return _Bezeichnung; }
            set
            {
                _Bezeichnung = value;
                RaisePropertyChange("Bezeichnung");
            }
        }


        private int _Amount;

        public int Amount
        {
            get { return _Amount; }
            set
            {
                _Amount = value;
                RaisePropertyChange("Amount");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChange(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       









    }
}
