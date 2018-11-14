using System;
using System.Collections.Generic;
using System.Text;

namespace _14nov18
{
    class GetSet
    {
        int _marks;
        string _name1;

        public int marks
        {
            get
            {
                return _marks;
            }
            set
            {
                _marks = value;
            }

        }
        public string name1
        {
            get
            {
                return _name1;
            }
            set
            {
                _name1 = value;
            }

        }
    }
}
