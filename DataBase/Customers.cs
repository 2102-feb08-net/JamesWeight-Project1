using System;
using System.Data.SqlClient;

namespace CustomerLibrary
{
    interface IInterface
    {
        void BusinessLogic(bool _display, string _readData, int _length, string[] _key, int _dataSet, string _query);
    }

    internal class Routines : IInterface
    {
        internal int ID { get; set; }         // Primary Key

        internal long Phone { get; set; }     // 12 Digit Internation Code
        internal int HomeStore { get; set; }  // Integer

        internal string Name { get; set; }    // VarChar(100)
        internal string Address { get; set; } // VarChar(300)
        internal string eMail { get; set; }   // VarChar(100)

        public void BusinessLogic(bool _display, string _readData, int _length, string[] _key, int _dataSet, string _query)
        {
            if (_display)
            {
                // New Line
                Console.WriteLine(" ");
                // Message to User
                Console.WriteLine("Validation on Customers."); // SI - TDD
                // for (int _index = 0; _index < _length; _index ++){ Console.WriteLine(_key[_index] + ": " + _readData[_index]); }
                // set Domain Class Information
                ID = Convert.ToInt32(_readData[0]);
                Name = _readData[1].ToString();
                Address = _readData[2].ToString();
                Phone = Convert.ToInt64(_readData[3]);
                eMail = _readData[4].ToString();
                HomeStore = Convert.ToInt32(_readData[5]);
                // Validation with Business Logic
                if (ID < 0) ID = 0;
                if (HomeStore < 0) HomeStore = 0;
                if (Name == String.Empty) Name = "Enter Name";
                if (Phone < 10000000000 ) Phone = 100000000000;
                
            }
        }
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net
//
//  Project0 - Feb 12, 2021 Received Original Specifications
//           - Feb 18, 2021 Received Requested Specifications
//           - Feb 24, 2021 Requested Deliverable
//           - Mar 1, 2021  Deliverable
//
//  Project Lead - Revature Corporate Trainor Nick Escalona
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight