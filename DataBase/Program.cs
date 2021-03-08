using System;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataBase.");
            Api.Start _logic = new Api.Start();
             _logic.Begin();
        }
    }
}
