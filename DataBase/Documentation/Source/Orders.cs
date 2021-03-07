using System;

namespace OrderLibrary
{
    interface IInterface
    {
        void BusinessLogic(bool _display, string _readData, int _length, string[] _key, int _dataSet, string _query);
    }

    internal class Routines : IInterface
    {
        internal int ID { get; set; }  // Primary Key

        internal int CustomerID { get; set; } // Foreign Key
        internal int LocationID { get; set; } // Foreign Key
        internal int ProductID { get; set; } // Foreign Key

        internal int DealsPercentageReduction { get; set; } // Special Deal
        internal int DealsAmountReduction { get; set; } // Special Deal

        internal string Record { get; set; } // Date Time Offset UTC

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
                CustomerID = Convert.ToInt32(_readData[1]);
                LocationID = Convert.ToInt32(_readData[2]);
                ProductID = Convert.ToInt32(_readData[3]);
                Record = _readData[4].ToString();
                DealsPercentageReduction = Convert.ToInt32(_readData[5]);
                DealsAmountReduction = Convert.ToInt32(_readData[6]);
                // Validation with Business Logic
                if (ID < 0) ID = 0;
                if (CustomerID < 0) CustomerID = 0;
                if (LocationID < 0) LocationID = 0;
                if (ProductID < 0) ProductID = 0;

                if (DealsPercentageReduction < 0 ) DealsPercentageReduction = 0;
                if (DealsPercentageReduction > 100 ) DealsPercentageReduction = 100;
                if (DealsAmountReduction < 0 ) DealsAmountReduction = 0;
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