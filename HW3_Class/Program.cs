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
        //SQUARE_BY_SIMBOL TASK1
        class SquareSymbol
        {
            uint _length;
            char _symbol;
            public SquareSymbol(uint length, char symbol)
            {
                _length = length;
                _symbol = symbol;
            }
            public void draw()
            {
                for (int i = 0; i < _length; i++)
                {
                    for (int j = 0; j < _length; j++)
                    {
                        Write(_symbol + " ");
                    }
                    WriteLine();
                }
            }
        }

        //IS_PALINDROM TASK2
        class Chislo
        {
            readonly int _number;
            public Chislo(int number = 0) { this._number = number; }
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
                if (reverseChislo == _number) isPalindrom = true;
                return isPalindrom;
            }
        }
        //ARRAY_FILTRATION TASK3
        class Array
        {
            char[] _originalArr;
            public Array(char[] originalArr)
            {
                _originalArr = originalArr;
            }
            public void print()
            {
                foreach (char ch in _originalArr) Console.Write($"{ ch}\t");
                WriteLine();
            }
            public Array ArrChange(params char[] eraseElements)
            {
                int Coincidence = 0;
                for (int i = 0; i < _originalArr.Length; i++)
                {
                    for (int j = 0; j < eraseElements.Length; j++)
                    {
                        if (_originalArr[i] == eraseElements[j])
                        {
                            _originalArr[i] = '\0'; Coincidence++;
                        }
                    }
                }
                char[] arr = new char[_originalArr.Length - Coincidence];
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
        // class SHOP TASK 6
        class Shop
        {
            public static string _classifier = "Classification is \"InternetShop\"";
            public static uint _counerObjShop = 0;
            readonly string _nameShop;
            string _description;
            string _address;
            string _telephoneNumber;
            string _eMail;
            public Shop(string nameShop, string eMail = "_____@______.___", string description = " ", string address = " ", string telephoneNumber = "+7_________")
            {
                _nameShop = nameShop;
                _description = description;
                _address = address;
                _telephoneNumber = telephoneNumber;
                _eMail = eMail;
                _counerObjShop++;
            }
            //public string NameShop { get; set; }
            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }
            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }
            public string TelephoneNumber
            {
                get { return _telephoneNumber; }
                set { _telephoneNumber = value; }
            }
            public string EMail
            {
                get { return _eMail; }
                set { _eMail = value; }
            }
            public override string ToString()
            {
                return $"Name \"{_nameShop}\"\t" + $"Description:{_description}\t" + $"Address:{_address}\t" + $"Tel.:{_telephoneNumber}\t" + $"EMail:{_eMail}\t";
            }

        }
        static void Main(string[] args)
        {
            ////////////////////////SQUARE_BY_SIMBOL/////////////////////////

            //SquareSymbol square1 = new SquareSymbol(11, '$');
            //square1.draw(); 

            ////////////////////////IS PALINDROM/////////////////////////
            ///
            //Chislo chi = new Chislo(55555555);
            //chi.print();
            //if (chi.isPalindrom()) WriteLine("Palindrom");
            //else WriteLine("Is NOT Palindrom");

            //////////////////////ARRAY FILTRATION//////////////////////

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

            //////////////////////SHOP_CREATOR//////////////////////////

            //Shop shopEngland = new Shop ("Liverpool");
            //WriteLine(shopEngland);
            //shopEngland.EMail="Liver@mail.com";
            //shopEngland.TelephoneNumber="+79110000000";
            //shopEngland.Description = "flee_market";
            //shopEngland.Address = "England, Liverpool, PaulMcCartney str.b.56"; 
            //WriteLine(shopEngland);
            //WriteLine(Shop._classifier +"\t"+"Number of shops: "+Shop._counerObjShop); 
        }
    }
}
