﻿

using c_day5;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {

        MultiIndex mi1 = new MultiIndex();
        
        mi1[1] = "One";
        mi1[2] = "Two";
        mi1[3] = "Three";

        mi1["One"] = "2";
        mi1["five"] = "5";

        Console.WriteLine(mi1[1]);
        Console.WriteLine(mi1["One"]);
        //Console.WriteLine(mi1["two"]);
        //Console.WriteLine(mi1["five"]);


        //Indexer index1 = new Indexer();
        //index1[0] = "Rock";
        //index1[1] = "Paper";
        //index1[2] = "Scissor";

        //for(int i =0;i< Indexer.size;i++)
        //{
        //    Console.WriteLine(index1[i]);
        //}

        //Person per1 = new Person();
        //Console.WriteLine("enter the age :");
        //per1.Age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(per1.Age);

        // Prop p1 = new Prop();
        //  Prop p2 = new Prop();
        //p1.Name = "Amy";
        //p1.Role = "Training";



        //Console.WriteLine(p1.Name);
        //Console.WriteLine(p1.Role);

        //Console.WriteLine(p1.Location);
        // Arrays.Single();

        //Arrays.Multi();
        // Arrays.Sort();

        //Arrays.Sortstring();

        //Arrays.JaggedArray();

    }
}