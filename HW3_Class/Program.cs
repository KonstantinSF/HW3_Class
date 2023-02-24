using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace HW3_Class
{
    internal class Program
    {

//IS_PALINDROM
        class Chislo
        {
            readonly int _number;
            public Chislo(int number=0) { this._number = number; }
            //public int get (){return this._number; }
            public void print()
            {
                Console.WriteLine(_number); 
            }
            public bool isPalindrom()
            {
                bool isPalindrom = false;
                int chislo = _number;
                int exponent = -1;
                int reverseChislo = 0; 
                while (chislo != 0)
                {
                    chislo /= 10; 
                    exponent++;
                }
                chislo = _number; 
                while (chislo != 0)
                {
                    reverseChislo += (chislo % 10) * (int)Math.Pow(10, exponent--);
                    chislo /= 10; 
                }
                if (reverseChislo == _number) isPalindrom=true;
                return isPalindrom; 
            }
        }
//ARRAY_FILTRATION
class Array
        {
            char[] _originalArr;
            public Array (char[]originalArr)
            {
                _originalArr = originalArr;
            }
            public void print()
            {
                foreach(char ch in _originalArr) Console.Write($"{ ch}\t"); 
                WriteLine();
            }
            public Array ArrChange (params char[]eraseElements)
            {
                int Coincidence = 0;
                for (int i =0; i<_originalArr.Length; i++)
                {
                    for (int j=0; j<eraseElements.Length; j++)
                    {
                        if (_originalArr[i] == eraseElements[j]) 
                        {
                            _originalArr[i]= '\0'; Coincidence++;
                        }
                    }
                }
                char[] arr = new char[_originalArr.Length-Coincidence];
                int count = 0;
                for (int i = 0; i < _originalArr.Length; i++)
                {
                    if (_originalArr[i] != '\0')
                    {
                        arr[count++] = _originalArr[i];
                    }
                }
                _originalArr = arr;
                return this; 
            }
        }

        static void Main(string[] args)
        {
            ////////////////////////IS PALINDROM/////////////////////////
            //Chislo chi = new Chislo(3232323);
            //chi.print();
            //if (chi.isPalindrom()) WriteLine("Palindrom");
            //else WriteLine("Is NOT Palindrom"); 
            //////////////////////////ARRAY FILTRATION////////////////////
            //char[] arrCheck = { 'j', '7', '*', '%', '0', '\\' };
            //char[] eraseCheck = { 'j', '\\' };
            //Array check1 = new Array(arrCheck);
            //WriteLine("Original Array: "); 
            //check1.print();
            //WriteLine("Filtration parameters: ");
            //foreach (char c in eraseCheck) Write($"{c}\t"); 
            //WriteLine(); 
            //check1.ArrChange(eraseCheck);
            //WriteLine("Changed Array: "); 
            //check1.print();

        }
    }
}
