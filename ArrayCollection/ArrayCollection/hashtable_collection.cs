
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayCollection
{
    class hashtable_collection
    {
        static void Main(string[] args)
        {
            // hashtable contains key-value pair

            Hashtable hash_table = new Hashtable();

            // add data 
            hash_table.Add("ID", 1);
            hash_table.Add("Name", "ABC");
            hash_table.Add("Salary", 20000);
            hash_table.Add("Position", "XYZ");


            // print keys
            //foreach (var key in hash_table.Keys)
            //{
            //    Console.WriteLine("Key: " + key);
            //}

            // print values
            //foreach (var value in hash_table.Values)
            //{
            //    Console.WriteLine("Values: " + value);
            //}

            // print hashtable
            //foreach (DictionaryEntry items in hash_table)
            //{
            //    Console.WriteLine("Key : " + items.Key + " Value: " + items.Value);
            //}


            // Remove by Keys
            hash_table.Remove("Position");

            //Console.WriteLine("Postion Present? : "+ hash_table.ContainsKey("Position"));

            // After removing
            //foreach (DictionaryEntry items in hash_table)
            //{
            //    Console.WriteLine(items.Key + " : " + items.Value);
            //}

            //Console.WriteLine("ID Present? : "+ hash_table.ContainsKey("ID"));

            // To update
            //if(hash_table.ContainsKey("ID"))
            //{
            //    hash_table["ID"]=2;
            //}

            //foreach (DictionaryEntry items in hash_table)
            //{
            //    Console.WriteLine(items.Key + " : " + items.Value);
            //}


            // To delete hash-table data
            hash_table.Clear();
            Console.ReadLine();
        }
    }
}
