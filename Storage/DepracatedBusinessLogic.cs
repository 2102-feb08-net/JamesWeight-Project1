        /* 
    
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
                // Validation with Business Logic
                if (ID < 0) ID = 0;
                if (Name == String.Empty) Name = "Enter Name";
                if (Phone < 10000000000 ) Phone = 100000000000;            }
        }
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

        */