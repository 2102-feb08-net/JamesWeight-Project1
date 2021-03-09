using System;
using System.Diagnostics;
using System.Threading;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application:");

            Process.Start(@"../Menu/bin/Debug/net5.0/Menu.exe");
            Process.Start(@"../Browser/bin/Debug/net5.0/Browser.exe");
            Process.Start(@"../DataBase/bin/Debug/net5.0/DataBase.exe");

            Process.Start(@"c:/Program Files/Google/Chrome/Application/chrome.exe");
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
