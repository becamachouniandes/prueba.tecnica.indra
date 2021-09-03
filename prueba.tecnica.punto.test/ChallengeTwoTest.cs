using Microsoft.VisualStudio.TestTools.UnitTesting;
using prueba.tecnica.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.tecnica.punto.test
{
    [TestClass]
    public class ChallengeTwoTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
             {
                90,
                30,
                new List<int> {10,60,40,35,20},
                new List<int> {40,20}
             };
        }

        [TestMethod]
        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void Success(int capacity, int space, List<int> package,List<int> resultValid)
        {
            ChallengeTwo challenge = new ChallengeTwo();
            int[] result = challenge.Test(capacity,space,package.ToArray());
            CollectionAssert.AreEqual(resultValid, result);
        }
    }
}
