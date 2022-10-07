namespace Recursion_and_numbers.Classes
{
    public class Number
    {
        private readonly int[] _numbers;
        private readonly int _index;

        public int[] Numbers
        {
            get { return _numbers; }
        }

        public int Index
        {
            get { return _index; }
        }

        public Number(Number numberArray)
        {
            _numbers = new int[numberArray.Numbers.Length * 2 + 1];
            _index = numberArray.Index + 1;
            int i = 0;

            for (; i < numberArray.Numbers.Length; i++)
            {
                _numbers[i] = numberArray.Numbers[i];
            }
            _numbers[i] = _index; i++;
            for (int j = 0; j < numberArray.Numbers.Length; j++)
            {
                _numbers[i] = numberArray.Numbers[j];
                i++;
            }
        }

        public Number()
        {
            _index = 1;
            _numbers = new int[1];
            _numbers[0] = 1;
        }
    }
}