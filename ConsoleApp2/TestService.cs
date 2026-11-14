using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TestService : IDataService
    {
        public string GetData()
        {
            return "Hello from DataService!";
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
