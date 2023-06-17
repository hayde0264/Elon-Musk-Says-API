using System.Text.Json;  
using System;
using System.IO;

namespace SerializeToFile 
{ 
    public class Data 
    {  
        public string quote { get; set; } 

        public void serialize() 
        {  
            List<Data> list = new List<Data>();   
            list.Add(new Data { quote = "The first step is to establish that something is possible; then probability will occur. - Elon Musk"});  
            list.Add(new Data { quote = "I think that is the single best piece of advice: constantly think about how you could be doing things better and questioning yourself. - Elon Musk"}); 
            list.Add(new Data { quote = "If you get up in the morning and think the future is going to be better, it is a bright day. Otherwise, it’s not. - Elon Musk"}); 
            list.Add(new Data { quote = "Persistence is very important. You should not give up unless you are forced to give up. - Elon Musk"});  
            list.Add(new Data { quote = "I think it’s very important to have a feedback loop, where you’re constantly thinking about what you’ve done and how you could be doing it better. - Elon Musk"}); 
            list.Add(new Data { quote = "I would like to die on Mars. Just not on impact. - Elon Musk"}); 

             

            var format = new JsonSerializerOptions { WriteIndented = true }; 
            string json = JsonSerializer.Serialize(list, format); 
            File.WriteAllText(@"/Users/hayde/Desktop/test.json", json); 

        }
    } 
}