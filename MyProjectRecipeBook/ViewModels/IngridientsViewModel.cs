using MyProjectRecipeBook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectRecipeBook.ViewModels
{
    internal class IngridientsViewModel : INotifyPropertyChanged
    {
        public IngridientsViewModel() 
        {
            IngridientsList = new ObservableCollection<Ingridients>();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Ingridients NeuesIngridient { get; set; }
        public ObservableCollection<Ingridients> IngridientsList { get; set; }

        private Ingridients _AusgewaehltesIngridient;
        public Ingridients AusgewaehltesIngridient 
        {
            get { return _AusgewaehltesIngridient; }
            set
            {
                _AusgewaehltesIngridient = value;
                RaisePropertyChanged("AusgewaehltesIngridient");
            }
        }
        IngridientsDBContext _ctx = new IngridientsDBContext();
        public void FillIngridientsFromDB()
        {
            IngridientsList = new ObservableCollection<Ingridients>();
            foreach (Ingridients ingridient in _ctx.IngridientsList)
            {
                IngridientsList.Add(ingridient);
            }
            
        }

        //private string _Statusanzeige;

        public string Statusanzeige
        {
            get
            {
                if (IngridientsList.Count == 0)
                {
                    return "There were no ingridients found in the list!";
                }

                return $"There are {IngridientsList.Count} Ingridients";
            }

        }
        public void AddIngridient()
        {
            //Clone -- Tiefe Kopie


            var ingridientNeu = new Ingridients()
            {
                Bezeichnung = NeuesIngridient.Bezeichnung,
                Amount = NeuesIngridient.Amount,
            };
            //Zur DB hinzufügen
            //_ctx.IngridientsList.Add(NeuesIngridient);
            _ctx.IngridientsList.Add(NeuesIngridient);
            _ctx.SaveChanges();
            //zur ObservableCollection hinzufügen
            IngridientsList.Add(ingridientNeu);
           }
        
        private int _DeleteId;

        public int DeleteId
        {
            get { return _DeleteId; }
            set { _DeleteId = value;

                RaisePropertyChanged("DeleteId");

            }
        }

        internal void DeleteProdukt(int DeleteId)
        {  
            
            
            var pDelete = _ctx.IngridientsList.Find(DeleteId);
            
            _ctx.IngridientsList.Remove(pDelete );
            _ctx.SaveChanges();
            //zur ObservableCollection hinzufügen
            IngridientsList.Remove(AusgewaehltesIngridient);
            RaisePropertyChanged("Statusanzeige");

        }

        private void NotFound()
        {
            throw new NotImplementedException();
        }

        public string SuchText { get; set; }
        internal void FilterIngridients()
        {
            IngridientsList = new ObservableCollection<Ingridients>();
            foreach (Ingridients ingridient in
                _ctx.IngridientsList.Where(p=>p.Bezeichnung.Contains(SuchText)))
            {
                IngridientsList.Add(ingridient);
            }
            RaisePropertyChanged("IngridientsList");
            RaisePropertyChanged("Statusanzeige");

        }
    }
}
