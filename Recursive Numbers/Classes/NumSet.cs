using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_and_numbers.Classes
{

    public class NumSet
    {

        private Number[] _set;
        private int _size;

        public Number[] Set
        {
            get { return _set; }
        }

        public int Size
        {
            get { return _size; }
        }

        public NumSet()
        {
            _size = 1;
            _set = new Number[Size];
            _set[0] = new Number();
        }

        public void Add()
        {
            Array.Resize(ref _set, Size + 1);
            _size++;
            _set[Size - 1] = new Number(_set[Size - 2]);
        }

        public int SetNumbers(int index)
        {
            string numbers = "";
            for (int i = 0; i < Set[index].Numbers.Length; i++)
            {
                numbers += Set[index].Numbers[i];
            }

            return Int32.Parse(numbers);
        }
    }
}
