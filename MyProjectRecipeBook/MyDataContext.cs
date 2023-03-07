using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectRecipeBook
{
    internal class MyDataContext
    {

        private string _PreparationTime;
        public string PreparationTime
        { 
            get { return _PreparationTime; } 
            set { _PreparationTime = value; } }

        private int _Time1;

        public int Time1
        {
            get { return _Time1; }
            set { _Time1 = value; }
        }

        private int _Time2;

        public int Time2
        {
            get { return _Time2; }
            set { _Time2 = value; }
        }

        private int _Time3;

        public int Time3
        {
            get { return _Time3; }
            set { _Time3 = value; }
        }

        private int _Time4;

        public int Time4
        {
            get { return _Time4; }
            set { _Time4 = value; }
        }
    }
}
