using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    partial class Airline
    {
        static Airline() //статический конструктор
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-----------------------------------");
            amount_of_objects++;
        }
        private Airline(int num) { } //закрытый конструктор
        public Airline()
        {
            Console.WriteLine($"Пункт назначения: {Destination}, \nномер рейса: {Flight_Number}, \nтип самолета: {type}, \nвремя: {Time}, \nдень: {Days}");
            Console.WriteLine("-----------------------------------");
            amount_of_objects++;
        }

        public Airline(string second_destination, string second_day, int num)
        {
            if ((num < 1000 && num > 0) || num == 0) //проверка на корректность
            {
                Console.WriteLine($"Пункт назначения: {Destination = second_destination}, \nномер рейса: {Flight_Number = num}, \nтип самолета: {type}, \nвремя: {Time}, \nдень: {Days = second_day}");
                Console.WriteLine("-----------------------------------");
                amount_of_objects++;
            }
            else
            {
                Console.WriteLine("Некорректные данные!");
            }
        }

        public Airline(string def_destination, int def_flight_number, string def_time, string def_days) //конструктор с параметрами по умолчанию
        {
            Console.WriteLine($"Пункт назначения: {Destination = def_destination}, \nномер рейса: {Flight_Number = def_flight_number}, \nтип самолета: {Type = type}, \nвремя: {Time = def_time}, \nдень: {Days = def_days}");
            Console.WriteLine("-----------------------------------");
            amount_of_objects++;
        }

        //поля и их свойства
        public string Destination { get; set; }
        public int Flight_Number { get; private set; }

        private const string type = "Passenger"; //поле-константа
        public string Type { get; set; }
        public string Time { get; set; }
        public string Days { get; set; } //добавление корректности ломает все(



        public static int amount_of_objects = 0; //статическое поле

        private readonly int ID; //поле только для чтения
    }
}
