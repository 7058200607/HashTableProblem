using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    public class program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hash table");
            MyMapNode<string,string> hash = new MyMapNode<string,string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash1=hash.Get("1");
            Console.WriteLine("1th index value :" + hash1);
            string hash2=hash.Get("2");
            Console.WriteLine("2th index value :" + hash2);
            string hash3=hash.Get("3");
            Console.WriteLine("3th index value :" + hash3);
            string hash4=hash.Get("4");
            Console.WriteLine( "4th index value :" +hash4);
            string hash5=hash.Get("5");
            Console.WriteLine("5th index value :" + hash5);
         
           
        }
    }
}

