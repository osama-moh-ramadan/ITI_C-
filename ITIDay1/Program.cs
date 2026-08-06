using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // problem 01
            // part 01
            sbyte SeatsNum;
            sbyte RoomNum;
            sbyte Age;
            //part 02
            long TicketSerial;
            long PrintedTickets;
            int ZoneCode;

            //part 04
            string CustomerName;
            char MembershipTierCode;
            bool IsVIP;

            //problem 02
            /*
             byte student-age = 20;
               uint distance = -500;
               int 1stPlayerScore = 1000;
               long itemsCount = 50;
               short temperature = 40000;
            */
            byte student_age = 20;
            int distance = -500;
            int stPlayerScore = 1000;
            long itemsCount = 50;
            ushort temperature = 40000;

            // problem 03
            //13.	Declare an integer named currentStock with a value of 500.
            // no errors and will store it in the stack
            //14.	Declare an integer named backupStock and assign the value of currentStock to it.
            //  will store in stack too
            //15.	Increment currentStock by 100.
            // will change value in stack
            // 16.	Print both variables.
            int CurrentStock = 500;
            int BackupStock = CurrentStock;
            CurrentStock += 100;
            Console.WriteLine($"current stock equal : {CurrentStock} , and backup stock equal {BackupStock}");






        }
    }
}
