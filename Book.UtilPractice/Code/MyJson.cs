using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Book.UtilPractice.Code
{
    class MyJson
    {
        public void M1()
        {
            var p1 = new JObject
            {
                ["name"] = "孙小双",
                ["age"] = 29
            };
            var score1 = new JArray
            {
                new JObject{ ["name"] = "语文", ["score"] = 89 },
                new JObject{ ["name"] = "数学", ["score"] = 126 },
                new JObject{ ["name"] = "英语", ["score"] = 85 }
            };
            p1["scoreList"] = score1;
            Console.WriteLine(p1);
        }

        public void M2()
        {
            var p = new { name = "孙小双", age = 29, score = new[] { new { name = "语文", score = 87 }, new { name = "数学", score = 130 } } };
            Console.WriteLine(JsonConvert.SerializeObject(p)); 
            Console.WriteLine(JsonConvert.SerializeObject(p, Formatting.None));
        }

        public void M3()
        {
            var serialize = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });
            using (var write = File.CreateText(Path.Combine(Environment.CurrentDirectory, "Data", "Save", "jsonserializer.json")))
            {
                var p = new { name = "孙小双", age = 29, score = new[] { new { name = "语文", score = 87 }, new { name = "数学", score = 130 } } };
                serialize.Serialize(write, p);
            }
        }
        

    }
}
