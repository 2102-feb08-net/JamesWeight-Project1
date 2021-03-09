using System;

namespace Customer.Library
{
    interface IInterface
    {
        string Data_Logic(object DataInformation);
        string Server_Validation(object DataInformation);
        string Business_Logic(object DataInformation);
    }

    public class Routines : IInterface
    {
        public int ID { get; set; }         // Primary Key

        public long Phone { get; set; }     // 12 Digit Internation Code
        public int HomeStore { get; set; }  // Integer

        public string Name { get; set; }    // VarChar(100)
        public string Address { get; set; } // VarChar(300)
        public string eMail { get; set; }   // VarChar(100)
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
