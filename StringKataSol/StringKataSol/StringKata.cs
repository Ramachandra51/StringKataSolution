using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataInterview
{
    class StringKata
    {
        static void Main(string[] args)
        {
            AddNumbers("");
        }

        public static int AddNumbers(string s)
        {
            int returnValue = 0;
            if (!string.IsNullOrEmpty(s))
            {
                var splitString = s.Split(',','\n',';');

                if (splitString.Length>1)
                {
                    int temp = 0;
                    for (int i = 0; i < splitString.Length; i++)
                    {
                        int number;
                        var isValid = int.TryParse(splitString[i], out number);
                        if (isValid)
                        {
                            temp = temp + Convert.ToInt32(splitString[i]);
                        }
                        
                    }
                    returnValue = temp;
                }
                else
                {
                    returnValue =Convert.ToInt32(s);
                }
            }
            return returnValue;
        }
    }
}
