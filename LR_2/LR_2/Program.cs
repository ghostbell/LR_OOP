using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    internal class Program
    {
        static void Main()
        {
            Airline first_airline = new Airline(); //вызов конструктора без параметров
            Airline second_airline = new Airline("Москва", "Понедельник", 128); //вызов конструктора с параметрами

            string def_destination = "";
            int def_flight_number = 0;
            string def_time = "";
            string def_days = "";

            Airline third_airline = new Airline(def_destination, def_flight_number, def_time, def_days); //вызов конструктора с параметрами по умолчанию

            Airline.Print_Info(ref third_airline); //ref

            //Console.WriteLine(Airline.amount_of_objects); //вывод количества созданных объектов

            Console.WriteLine(second_airline.Equals(first_airline));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(third_airline.ToString());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(first_airline.GetType());
            Console.WriteLine("-----------------------------------");

            //массив объектов
            Airline[] array = new Airline[5];
            Airline first = new Airline("Moscow", 845, "16:00", "Monday");
            array[0] = first;
            Airline second = new Airline("Odessa", 618, "12:00", "Tuesday");
            array[1] = second;
            Airline third = new Airline("Paris", 527, "17:40", "Tuesday");
            array[2] = third;
            Airline fourth = new Airline("Moscow", 452, "10:20", "Saturday");
            array[3] = fourth;
            Airline fifth = new Airline("Oslo", 192, "15:30", "Tuesday");
            array[4] = fifth;

            Console.WriteLine("Введите пункт назначения: ");
            string input_dest = Console.ReadLine();
            foreach (Airline airlines in array)
            {
                if (input_dest == airlines.Destination)
                {
                    Console.WriteLine(airlines.ToString());
                }
            }
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Введите день: ");
            string input_day = Console.ReadLine();
            foreach (Airline airlines in array)
            {
                if (input_day == airlines.Days)
                {
                    Console.WriteLine(airlines.ToString());
                }
            }
            Console.WriteLine("-----------------------------------");


            //анонимный тип
            var anon = new {destination = "New York", number = 246, tp = "Passenger", tm = "19:25", dy = "Wednesday"};
            Console.WriteLine($"Пункт назначения: {anon.destination}, \nномер рейса: {anon.number}, \nтип: {anon.tp}, \nвремя: {anon.tm}, \nдень: {anon.dy}");
        }
    }
}
