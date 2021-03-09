using System;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataBase:");

            DBapp.Start _instantiate = new DBapp.Start();
            _instantiate.Selection();
        }
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net Nick Escalona
//
//  Project1 - Presentation Start at Tuesday, Mar. 8
//
//  Project Lead - Revature Corporate Trainor Nick Escalona
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight
