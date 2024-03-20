using System.Collections;
using System.Collections.Generic;

namespace recursive.Task34
{
	public class Recursive_ThirdTask
    {
		public static int computeLengthList(List<string> list)
		{

            try
            {
                list.RemoveAt(0);
            }
            catch (Exception)
            {
                return 0;
            }

            return 1 + computeLengthList(list);
		}
	}

    public class Recursive_FourthTask
    {
        public static bool isPolindrom(string row)
        {
            if (row.Length < 2)
                return true;

            if (row.ElementAt(0) == row.ElementAt(row.Length - 1))
                return isPolindrom(row.Substring(1, row.Length - 2));

            return false;
        }
    }
}

