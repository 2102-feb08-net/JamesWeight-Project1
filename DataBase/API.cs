using System;
using System.Data.SqlClient;

namespace DBapp
{
    internal class Start
    {
        internal void Selection()
        {   
            // Temporary Set for Initial Process of Business Logic as Disabled or NULL in Functioning
            // SqlDataReader _classTemporary = new SqlDataReader();
            string[] _temporaryArray = {"1", "2", "3"};
            // SI - TDD : BusinessLogic(false, String.Empty, -1, [1,2,3], -1, "") => Prevent From Command Execution at Start of Run-Time
            //                                                                       ^- for Structural Integrity Test
            CustomerLibrary.Routines _logicCL = new CustomerLibrary.Routines(); _logicCL.BusinessLogic(false, "", -1, _temporaryArray, -1, "");
            ProductLibrary.Routines _logicPL = new ProductLibrary.Routines(); _logicPL.BusinessLogic(false, "", -1, _temporaryArray, -1, "");
            LocationLibrary.Routines _logicLL = new LocationLibrary.Routines(); _logicLL.BusinessLogic(false, "", -1, _temporaryArray, -1, "");
            OrderLibrary.Routines _logicOL = new OrderLibrary.Routines(); _logicOL.BusinessLogic(false, "", -1, _temporaryArray, -1, "");
            // Register to End Program
            bool _complete = false;
            // Title
            Console.WriteLine(" " + (char)13 + (char)10 + " ");
            string _data = "Welcome to the Market Locations Inventory Management Application";
            Console.WriteLine(_data + (char)13 + (char)10);
            // Display Menu
            DisplayMenu(_data);
            // Toggle Mode
            bool _entityMode = false;
            // Main Iteration of User Interface
            do
            {
                // check for Key Pressed as ASCII
                int _key = Console.Read();
                // Flow-Chart Pointers
                if (_key == 48) _complete = true;
                // ----------
                if (_key == 57) DisplayMenu(_data);
                // Get Table Records
                if (_key == 85 || _key == 117){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Name", "Address", "Phone Number", "eMail Address", "Home Store Preference"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Customers", 6, _send, 0);
                    }
                }
                // ----- I / i----- Location Functions
                if (_key == 73 || _key == 105){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Name", "Address", "Phone Number", "eMail Address"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Locations", 5, _send, 1);
                    }
                }
                // ----- I / i ----- Product Functions
                if (_key == 79 || _key == 111){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "At Location Identifier", "Name", "Description", "Price", "Quantity In Location"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Products", 6, _send, 2);
                    }
                }
                // ----- I / i ----- Order Functions
                if (_key == 80 || _key == 112){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Customer Reference #", "Location Reference #", "Product Reference #", "Record Date", "Percentage Off", "Reduced Amount"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Orders", 6, _send, 3);
                    }
                }
            }
            while (!_complete);
        }
        // Display Menu Method
        static void DisplayMenu(string _data)
        {
            // Menu
            Console.WriteLine
            (
                new String('=', _data.Length) + (char)13 + (char)10             
                + "Choose your task via KeyPress and then Press 'Enter'." + (char)13 + (char)10
                + new String('=', _data.Length) + (char)13 + (char)10
                + "U) View Table Customers" + (char)13 + (char)10 // 85, 117
                + "I) View Table Locations" + (char)13 + (char)10 // 73, 105
                + "O) View Table Products" + (char)13 + (char)10 // 79, 111
                + "P) View Table Orders" + (char)13 + (char)10 // 80, 112
                + new String('#', _data.Length) + (char)13 + (char)10 //
                + "0) Exit" + (char)13 + (char)10 // 48
                + "9) Redisplay Menu" + (char)13 + (char)10 // 57
            );
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