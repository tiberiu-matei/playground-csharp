using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Generic;
using System.Linq;

namespace Playground.Benchmark
{
    [SimpleJob(RuntimeMoniker.Net50)]
    public class CollectionsBenchmark
    {
        private List<FakeUser> list;

        private FakeUser[] array;

        [Params(10000, 1000000)]
        public int CollectionSize;

        [GlobalSetup]
        public void Setup()
        {

        }

        [Benchmark]
        public FakeUser FindLastInList()
        {
            list = new List<FakeUser>();

            for (var i = 0; i < CollectionSize; i++)
            {
                var user = CreateUser(i);

                list.Add(user);
            }

            return list.Last();
        }

        [Benchmark]
        public FakeUser FindLastInArray()
        {
            var x = new Dictionary<string, int>();

            array = new FakeUser[CollectionSize];

            for (var i = 0; i < CollectionSize; i++)
            {
                var user = CreateUser(i);

                array[i] = user;
            }

            return array[array.Length - 1];
        }

        private FakeUser CreateUser(int id)
        {
            return new FakeUser
            {
                Id = id,
                Name = "big random string boysssssssssssssssssss",
                LastName = "omegalul omegalul omegalul omegalul omegalul omegalul " +
                        "omegalul omegalul 457547omegalul om123123egalul omegalul omegalul omegalul omegalul " +
                        "omeg4alul o454mega234lul ome457galul omegalul omegalsadul omegalul omegalul omegalul " +
                        "omegalul 234om23egalul omegalul omegalul omeg234alul omegalul o123123megalul omegalul " +
                        "omega34234lul omega123lul omega1231ul omegalul omegalul omegalul omegalul21 omegalul " +
                        "omegalul ome23galul omegs4alul omegal213312ul omegalul omegalul omegalul omegalul " +
                        "omega32434lul ome23gazzxcxzct4ylul omegs4alul 212aazzz omegalul omegalul omegalul omegalul " +
                        "omegalul ome23galul omegs4alul omegal2133712ul omegalu4y47l omegalul omegalul omegalul " +
                        "omega234lul ome123ga2312312a3lul omegalul o15474572ul omegalul omegalul omegalul omegalul omegalul " +
                        "omegalul omegalul omegalul omegalul 321432143342344 omegal22ul omegalul omegalul " +
                        "om2342egalul omegalul omegalulaease omegaesul omegalul 1 omegalul omegalul " +
                        "omegalul omeg2123123lul757 omegalul o2megalul om57egalul omegalul omegalul omegalul " +
                        "omega234lul omegalul omega123lul omegalul omegalul omegalul omegalul omegalul " +
                        "omegal23ul234 omegalul omega4575475lu457l omegalul omegalu3l omegalul omegalul omegalul "
            };
        }
    }

    public class FakeUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }
    }
}
