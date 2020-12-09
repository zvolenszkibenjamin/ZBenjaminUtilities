using System;
using System.Collections.Generic;
using NUnit.Framework;
using ZBenjaminUtilities;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var values = new List<string>()
            {
                "egyes", "kettes", "hármas", "négyes", "ötös", "hatos", "hetes", "nyolcas",
                "kilences", "tizes", "tizenegyes", "meddig fogom még ezt a szart itt kiírni vajon",
                "hát igazából nem tom",
                "de nagyon unom már", "mer egy szar", "legyen má vége", "jó tudom én csinálom", "naaa lassan vége",
                "csak még kell egy pár item a teszthez", "jaaa, igen, egyébként ez a multisepjoinhoz tartózó teszt",
                ":)", "najóvan asszem ennyi", "érdekesen fog ez kinézni a githubon...", "na helló"
            };

            var seps = new Dictionary<int, string>()
            {
                { 1, ", " }, { 3, " °˘° " }, { 5, " - [öt] - " }, { 10, "\n" }, { 15, ";\n" }
            };
            
            Console.WriteLine("UNIT TEST\n-------------\n");
            Console.WriteLine(MultiSeparatorJoin.MultiSepJoin(seps, values));

            var values2 = new List<string>();
            for (var i = 1; i < 100; i++) values2.Add(i.ToString());
            
            var seps2 = new Dictionary<int, string>();
            seps2.Add(1, " - ");
            seps2.Add(10, " - [10] - ");
            seps2.Add(25, " - [25] - ");
            seps2.Add(90, " - [lassan vége] - ");
            
            Console.WriteLine($"\n{MultiSeparatorJoin.MultiSepJoin(seps2, values2)}");

            Assert.True(true);
        }
    }
}