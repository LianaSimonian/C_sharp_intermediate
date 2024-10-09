using System;
using System.Collections;
using System.Collections.Generic;


namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);//boxing
            list.Add("Mosh");
            list.Add(DateTime.Today);//boxing

            int number =(int) list[0];//unboxing

            var anotherList = new List<int>();
            anotherList.Add(1);
            var name = new List<string>();
            name.Add("Mosh");
        }
    }
}