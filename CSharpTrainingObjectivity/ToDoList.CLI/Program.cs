using Objectivity.CSharp.Interfaces;
using Objectivity.CSharp.Interfaces.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Logic;

namespace ToDoList.CLI
{
    class Program
    {
        static ToDoListEngineInterface engine;
        static void Main(string[] args)
        {
            engine = new ToDoListEngine();
            Console.WriteLine("To jest moja todo lista");
            InitTestData(3);
            Console.ReadKey();
        }

        static void InitTestData(int numberOfElements)
        {
            //petle
            Random rand = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                engine.AddTask(new ToDoTask()
                {
                    Id = i,
                    Title = $"Title{rand.Next(100)}",
                    Description = $"Description{rand.Next(100)}"
                });
            }
        }
    }
}
