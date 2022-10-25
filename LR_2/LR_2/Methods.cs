using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    partial class Airline
    {
        public static void Print_Info(ref Airline airline)
        {
            Console.WriteLine($"Пункт назначения: {airline.Destination}, \nномер рейса: {airline.Flight_Number}, \nтип самолета: {Airline.type}, \nвремя: {airline.Time}, \nдень: {airline.Days}");
            Console.WriteLine("-----------------------------------");
        }

        public override int GetHashCode()
        {
            return amount_of_objects ^ 3 + Flight_Number;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                Airline airline = (Airline) obj;
                return (airline.Days == Days) && (airline.Time == Time) && (airline.Destination == Destination) && (airline.Flight_Number == Flight_Number);
            }
        }

        public override string ToString()
        {
            string result = string.Format($"Пункт назначения: {Destination}, \nномер рейса: {Flight_Number}, \nтип самолета: {Type}, \nвремя: {Time}, \nдень: {Days}");
            return result;
        }
    }
}
