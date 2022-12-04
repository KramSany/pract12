using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract12
{
    class FindCentury
    {
        private int _year;
        public int Year { get { return _year; } set { _year = value; } }
        public FindCentury (int year)
        {
            _year = year;
        }
        public int Find()
        {
                return (_year / 100) + 1;
        }
    }
}
