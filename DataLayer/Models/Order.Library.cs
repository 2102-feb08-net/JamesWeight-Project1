using System;

namespace Order.Library
{
    interface IInterface
    {
        string Data_Logic(object DataInformation);
        string Server_Validation(object DataInformation);
        string Business_Logic(object DataInformation);
     }

    public class Routines : IInterface
    {
        public int ID { get; set; }  // Primary Key

        public int CustomerID { get; set; } // Foreign Key
        public int LocationID { get; set; } // Foreign Key
        public int ProductID { get; set; } // Foreign Key

        public int DealsPercentageReduction { get; set; } // Special Deal
        public int DealsAmountReduction { get; set; } // Special Deal

        public string Record { get; set; } // Date Time Offset UTC
        // ==========
        public string Data_Logic(object DataInformation)
        {
            string _result = String.Empty;

            return _result;
        }
        public string Server_Validation(object DataInformation)
        {
            string _result = String.Empty;

            return _result;
        }
        public string Business_Logic(object DataInformation)
        {
            string _result = String.Empty;

            return _result;
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
