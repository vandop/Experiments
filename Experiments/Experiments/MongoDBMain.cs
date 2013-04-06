using System.Collections.Generic;
using Experiments.DAO;
using MongoDB.Driver;
using System;

namespace Experiments
{
    public static class MongoDBMain
    {
        public static void Main(string[] args)
        {
            MongoClient client = new MongoClient();
            MongoServer server = client.GetServer();
            var clusterDb = server.GetDatabase("Cluster");

            var companies = clusterDb.GetCollection<Company>("Companies");

            var result = companies.Insert(new Company()
                {
                    Id = 221343237,
                    Employees = new List<Person>()
                        {
                            new Person()
                                {
                                    Age = 25,
                                    Name = "vando",
                                    Nif = 221343237
                                },
                            new Person()
                                {
                                    Age = 24,
                                    Name = "Axel",
                                    Nif = 123456789,
                                }
                        }
                });



            Console.WriteLine("Done - {0}", result.ErrorMessage);
            Console.ReadKey();
        }
    }
}
