using System;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            string number = num.ToString();
            if (number.Length > 3 && number.Length < 7)
            {
                number = number.Insert(number.Length - 3, ",");
                return number;
            }
            if (number.Length >= 7)
            {
                number = string.Format("{0:#,0}", num);
            }
            
                return number;
        }
    }
}
