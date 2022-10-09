using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool Tuesday = true;
            //Console.WriteLine(Tuesday);

            //byte _Byte; // 0 - 255
            //string input_byte = Console.ReadLine();
            //_Byte = Convert.ToByte(input_byte);
            //Console.WriteLine(_Byte);

            //sbyte _SByte; // -128 - 127
            //string input_sbyte = Console.ReadLine();
            //_SByte = Convert.ToSByte(input_sbyte);
            //Console.WriteLine(_SByte);

            //char symbol;
            //string input_symbol = Console.ReadLine();
            //symbol = Convert.ToChar(input_symbol);
            //Console.WriteLine(symbol);

            //decimal _decimal; //хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10^-28 до ±7.9228*10^28, может хранить 28 знаков после запятой и занимает 16 байт.
            //string input_decimal = Console.ReadLine();
            //_decimal = Convert.ToDecimal(input_decimal);
            //Console.WriteLine(_decimal);

            //double _double; //хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и занимает 8 байта.
            //string input_double = Console.ReadLine();
            //_double = Convert.ToDouble(input_double);
            //Console.WriteLine(_double);

            //float _float; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.
            //string input_float = Console.ReadLine();
            //_float = Convert.ToSingle(input_float);
            //Console.WriteLine(_float);

            //int _int; //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            //string input_int = Console.ReadLine();
            //_int = Convert.ToInt32(input_int);
            //Console.WriteLine(_int);

            //uint _uint; //хранит целое число от 0 до 4294967295 и занимает 4 байта.
            //string input_uint = Console.ReadLine();
            //_uint = Convert.ToUInt32(input_uint);
            //Console.WriteLine(_uint);

            //ulong _ulong; //хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            //string input_ulong = Console.ReadLine();
            //_ulong = Convert.ToUInt64(input_ulong);
            //Console.WriteLine(_ulong);

            ////nint _nint;

            ////nuint _nuint;

            //long _long; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            //string input_long = Console.ReadLine();
            //_long = Convert.ToInt64(input_long);
            //Console.WriteLine(_long);

            //short _short; //хранит целое число от -32768 до 32767 и занимает 2 байта.
            //string input_short = Console.ReadLine();
            //_short = Convert.ToInt16(input_short);
            //Console.WriteLine(_short);

            //ushort _ushort; //хранит целое число от 0 до 65535 и занимает 2 байта.
            //string input_ushort = Console.ReadLine();
            //_ushort = Convert.ToUInt16(input_ushort);
            //Console.WriteLine(_ushort);

            //object _object; //может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
            //string input_object = Console.ReadLine();
            //_object = Convert.ToString(input_object);
            //Console.WriteLine(_object);

            //распаковка и упаковка значимых типов
            int amount = 45;
            Object obj_amount = amount;
            int new_amount = (int)obj_amount;
            Console.WriteLine(new_amount);

            //работа с неявно типизированной переменной
            string text;
            var new_text = "Another text";
            Console.WriteLine(new_text);

            char? s = null;  //работа с переменной типа nullable
            Console.WriteLine(s);

            //var abc = 5;
            //abc = "fghjk";

            string str_one = "Hello World";
            string str_second = "Hello Universe";
            Console.WriteLine(String.Equals(str_one, str_second));

            string first_str = "first";
            string second_str = "second";
            string third_str = "third";
            //объединение строк
            Console.WriteLine(first_str + " " + second_str);

            //копирование
            string new_str_one = String.Copy(new_text);
            Console.WriteLine(new_str_one);
            
            //выделение подстроки
            Console.WriteLine(str_second.Substring(6, 8));

            //разбиение строки на подстроки
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine($"{word}");
            }

            //вставка подстроки в заданную позицию
            string original = "В языке слово звуковой и графической.";
            string add = " применяется в двух физических формах:";
            string modified_str = original.Insert(13, add);
            Console.WriteLine(modified_str);

            //удаление заданной подстроки
            string new_modified_str = modified_str.Remove(14, 15);
            Console.WriteLine(new_modified_str);

            //интерполяция строк
            string name = "Alexander";
            int age = 23;
            Console.WriteLine($"Hello, my name is {name}, I am {age} years old");
        }
    }
}
