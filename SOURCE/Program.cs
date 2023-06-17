using System.Text.Json; 
using System;
using System.IO;

namespace SerializeToFile
{
        public class Program
    {
        public static void Main()
        {  
            Data data = new Data(); 
            data.serialize(); 
        } 
       
    }
}
