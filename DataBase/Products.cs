using System;

namespace ProductLibrary
{
    interface IInterface
    {
        void BusinessLogic(bool _display, string _readData, int _length, string[] _key, int _dataSet, string _query);
    }

    public class Routines : IInterface
    {
        public int ID { get; set; }  // Primary Key

        public int LocationID { get; set; }  // Zipcode of Store
        public int Price { get; set; }  // In U.S. Dollars
        public int Quantity { get; set; }  // In Stock at LocationID

        public string Name { get; set; }    // VarChar(100)
        public string Description { get; set; } // VarChar(300)

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
                LocationID = Convert.ToInt32(_readData[1]);
                Name = _readData[2].ToString();
                Description = _readData[3].ToString();
                Price = Convert.ToInt32(_readData[4]);
                Quantity = Convert.ToInt32(_readData[5]);
                // Validation with Business Logic
                if (ID < 0) ID = 0;
                if (LocationID < 0) LocationID = 0;
                if (Name == String.Empty) Name = "Description";
                if (Price < 0 ) Price = 0;
                if (Quantity < 0 ) Quantity = 0;            }
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