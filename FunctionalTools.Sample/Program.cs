using System;
using System.Collections.Generic;
using System.Text.Json;
using Jcarchive.FunctionalTools;
using static Jcarchive.FunctionalTools.Generators;
using Microsoft.Graph;
using Newtonsoft.Json.Linq;
using File = System.IO.File;

namespace Program
{
    internal static class Program
    {
        public static void Main(params string[] args)
        {
            var names = ToCollection("Adam P. Smith", "Adam J. Johnson", "Erika Jobst", "James Gates", "Joseph Stallman");
            //
            var firstNames = names.Map(fullname => fullname.Split(" ")[0]);
            //
            var uniqueNames = ToSet(firstNames);
            uniqueNames.ForEach(Console.WriteLine);
            
            
            //
            var odds = FromRange(1, 100).Filter(n => n % 2 == 1);
            
            //
            var animals = "{ \"name\": \"Dog\", \"eyes\": 2 }\n" +
                          "{ \"name\": \"Spider\", \"eyes\": 8 }\n" +
                          "{ \"name\": \"Fly\", \"eyes\": 5 }\n" +
                          "{ \"name\": \"Human\", \"eyes\": 2 }";
            
                animals.Split('\n')
                .Map(user => JToken.Parse(user))
                .Filter( animal => !int.TryParse(animal["eyes"]?.ToString(), out var count) || count > 2)
                .Map(animal => animal["name"]?.ToString())
                .ForEach(Console.WriteLine);
                
        }

    }
}