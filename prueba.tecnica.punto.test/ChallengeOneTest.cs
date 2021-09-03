using Microsoft.VisualStudio.TestTools.UnitTesting;
using prueba.tecnica.business;
using System.Collections.Generic;

namespace prueba.tecnica.punto.test
{
    [TestClass]
    public class ChallengeOneTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new List<bool> { true,false,false,false,false,true,false,false },
                1,
                new List<bool> { false,true,false,false,true,false,true,false }
            };
            yield return new object[]
            {
                new List<bool> { true,true,true,false,true,true,true,true },
                1,
                new List<bool> { false,false,false,false,false,true,true,false }
            };
        }


        [TestMethod]
        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void Success(List<bool> houses, int days , List<bool> resultValid)
        {
            ChallengeOne challenge = new ChallengeOne();
            bool[] result = challenge.Test(houses.ToArray(),days);
            CollectionAssert.AreEqual(resultValid, result);
        }
    }
}
