﻿using Amazon;

namespace Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
        }
    }
}
