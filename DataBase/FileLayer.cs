using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FileIOlayer
{
    [XmlRootAttribute(IsNullable = false)]
    public class Routines
    {
        // Serialize into XML
        public void Serialization(object _readData, int _dataSet)
        {
            Console.WriteLine(_readData + " - " + _dataSet.ToString());
            // Customers
            if (_dataSet == 0)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(CustomerLibrary.Routines));
                TextWriter _output = new StreamWriter(@"./EncryptedCustomer.XML");
                CustomerLibrary.Routines _instantiation = new CustomerLibrary.Routines();
                // Send to File
                _encrypt.Serialize(_output, _instantiation);
                _output.Close();     
            }
            // Locations
            if (_dataSet == 1)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(LocationLibrary.Routines));
                TextWriter _output = new StreamWriter(@"./EncryptedLocation.XML");
                LocationLibrary.Routines _instantiation = new LocationLibrary.Routines();
                // Send to File
                _encrypt.Serialize(_output, _instantiation);
                _output.Close();     
            }            
            // Products
            if (_dataSet == 2)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(ProductLibrary.Routines));
                TextWriter _output = new StreamWriter(@"./EncryptedProduct.XML");
                ProductLibrary.Routines _instantiation = new ProductLibrary.Routines();
                // Send to File
                _encrypt.Serialize(_output, _instantiation);
                _output.Close();     
            }           
            // Orders
            if (_dataSet == 3)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(OrderLibrary.Routines));
                TextWriter _output = new StreamWriter(@"./EncryptedOrder.XML");
                OrderLibrary.Routines _instantiation = new OrderLibrary.Routines();
                // Send to File
                _encrypt.Serialize(_output, _instantiation);
                _output.Close();     
            }
        }

        // DeSerialize from XML 
        /*
        public void DeSerialization(object _readData, int _dataSet)
        {
            Console.WriteLine(_readData + " % " + _dataSet.ToString());
            // Customers
            if (_dataSet == 0)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(CustomerLibrary.Routines));
                CustomerLibrary.Routines_instantiation;
                // Read File
                using (Stream _process = new FileStream(@"./EncryptedCustomer.XML", FileMode.Open))
                {
                // Process
                _instantiation = (CustomerLibrary.Routines)serializer.Deserialize(_process);
                }
                // Write to object.
                Console.Write(_instantiation.ID + "\t");
                // Close Resource
                _process.Close();     
            }
            // Locations
            if (_dataSet == 1)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(LocationLibrary.Routines));
                CustomerLibrary.Routines _instantiation;
                // Read File
                using (Stream _process = new FileStream(@"./EncryptedLocation.XML", FileMode.Open))
                {
                // Process
                _instantiation = (CustomerLibrary.Routines)serializer.Deserialize(_process);
                }
                // Write to object.
                Console.Write(_instantiation.ID + "\t");
                // Close Resource
                _process.Close();             }
            // Products
            if (_dataSet == 2)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(ProductLibrary.Routines));
                CustomerLibrary.Routines _instantiation;
                // Read File
                using (Stream _process = new FileStream(@"./EncryptedProduct.XML", FileMode.Open))
                {
                // Process
                _instantiation = (CustomerLibrary.Routines)serializer.Deserialize(_process);
                }
                // Write to object.
                Console.Write(_instantiation.ID + "\t");
                // Close Resource
                _process.Close();
            }
            // Orders
            if (_dataSet == 3)
            {
                // Setup
                XmlSerializer _encrypt = new XmlSerializer(typeof(OrderLibrary.Routines));
                CustomerLibrary.Routines _instantiation;
                // Read File
                using (Stream _process = new FileStream(@"./EncryptedOrder.XML", FileMode.Open))
                {
                // Process
                _instantiation = (CustomerLibrary.Routines)serializer.Deserialize(_process);
                }
                // Write to object.
                Console.Write(_instantiation.ID + "\t");
                // Close Resource
                _process.Close();            }
        } */
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