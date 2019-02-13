using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    static class StringExtention
    {
        public static string ReEnd(this String str, int startPos, string addedStr)
        {
            char[] enteredStr = str.ToArray();
            char[] newEnteredStr = new char[enteredStr.Length-(enteredStr.Length-startPos)];
            for(int i=0; i<newEnteredStr.Length; ++i)
            {
                newEnteredStr[i] = enteredStr[i];
            }
            string resultString = new String(newEnteredStr);
            resultString += addedStr;

            return resultString;
        }
        public static string TypeImmit(this String str)
        {
            int i;
            char[] enteredStr = str.ToArray();
            for(i = 0; i < enteredStr.Length; ++i){
                Console.Write(enteredStr[i]);
                Thread.Sleep(Program.TEMP_OF_READING);
            }
            return "";
        }
    }
}
