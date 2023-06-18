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
            list.Add(new Data { quote = """The first step is to establish that something is possible; then probability will occur. - Elon Musk"""});
            list.Add(new Data { quote = """I think that is the single best piece of advice: constantly think about how you could be doing things better and questioning yourself. - Elon Musk"""});
            list.Add(new Data { quote = """If you get up in the morning and think the future is going to be better, it is a bright day. Otherwise, it's not. - Elon Musk"""});
            list.Add(new Data { quote = """Persistence is very important. You should not give up unless you are forced to give up. - Elon Musk"""});
            list.Add(new Data { quote = """I think it's very important to have a feedback loop, where you're constantly thinking about what you've done and how you could be doing it better. - Elon Musk"""});
            list.Add(new Data { quote = """I would like to die on Mars. Just not on impact. - Elon Musk"""});
            list.Add(new Data { quote = """I love the thought of a car drifting apparently endlessly through space and perhaps being discovered by an alien race millions of years in the future. - Elon Musk """});
            list.Add(new Data { quote = """The key test for an acronym is to ask whether it helps or hurts communication. - Elon Musk"""});
            list.Add(new Data { quote = """To make an embarrassing admission, I like video games. That's what got me into software engineering when I was a kid. I wanted to make money so I could buy a better computer to play better video games. Nothing like saving the world. - Elon Musk"""});
            list.Add(new Data { quote = """Optimism, pessimism, f*** that; we're going to make it happen. As God is my bloody witness, I'm hell-bent on making it work. - Elon Musk"""});
            list.Add(new Data { quote = """You could power the entire United States with about 150 to 200 square kilometers of solar panels, the entire United States. Take a corner of Utah... there's not much going on there, I've been there. There's not even radio stations. - Elon Musk"""});
            list.Add(new Data { quote = """I'm nauseatingly pro-American. I would have come here from any country. The U.S. is where great things are possible. - Elon Musk"""});
            list.Add(new Data { quote = """Any product that needs a manual to work is broken. - Elon Musk"""});
            list.Add(new Data { quote = """I've always wanted to be part of something that would radically change the world ...  People forget the power of inspiration. All of humanity went to the moon with the Apollo missions. The issue was cost. There was no chance to build a base and create frequent flights. That's the problem I would like to solve. - Elon Musk"""});
            list.Add(new Data { quote = """Entrepreneurship is like eating glass and walking on hot coals at the same time. - Elon Musk"""});
            list.Add(new Data { quote = """Ancient Greece had it all & then committed suicide. Nobody digs your grave better than yourself. - Elon Musk"""});
            list.Add(new Data { quote = """To our knowledge, life exists on only one planet, Earth. If something bad happens, it's gone. I think we should establish life on another planet--Mars in particular--but we're not making very good progress. SpaceX is intended to make that happen. - Elon Musk"""});
            list.Add(new Data { quote = """When I was in college, I wanted to be involved in things that would change the world. - Elon Musk"""});
            list.Add(new Data { quote = """I think life on Earth must be about more than just solving problems ... It's got to be something inspiring, even if it is vicarious. - Elon Musk"""});
            list.Add(new Data { quote = """I'd like to dial it back 5% or 10% and try to have a vacation that's not just e-mail with a view. - Elon Musk"""});
            list.Add(new Data { quote = """I just want to retire before I go senile because if I don't retire before I go senile, then I'll do more damage than good at that point. - Elon Musk"""});
            list.Add(new Data { quote = """Engineering is the closest thing to magic that exists in the world. - Elon Musk"""});
            list.Add(new Data { quote = """For my part, I will never give up, and I mean never. - Elon Musk"""});



            var format = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(list, format);
            File.WriteAllText(@"/Users/hayde/Desktop/Elon-Musk-Says-API/json/data.json", json);

        }
    }
}
