using System.Text.Json;
using demo_mstest_swp;

namespace UnitTesting
{
    //[TestClass]
    public class MathUtilsTesting
    {

        // Unit test for method MathUtils.GetSumNFirstNum
       // [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 3)]
        [DataRow(3, 6)]
        [DataRow(15, 120)]
        [DataRow(47, 1128)]
        [DataRow(10, 55)]
        [DataRow(100, 5050)]
        public void GetSumNFirstNum_NaturalNumber_ReturnRightValue(int n, int expectedValue)
        {
            var actualValue = MathUtils.GetSumNFirstNum(n);
            Assert.AreEqual(expectedValue, actualValue);
        }


        // Unit test for method MathUtils.IsPalindrome 

        /*public static IEnumerable<object[]> GetPalindromeData()
        {
            return new[]
            {
                    new object[] {1, true},
                    new object[] {21112, true},
                    new object[] {334433, true},
                    new object[] {3441443, true},
                    new object[] {47, false},
                    new object[] {2012323, false},
                    new object[] {333433, false},
                    new object[] {3441441, false},
             };
        }*/

        public static IEnumerable<object[]> PalindromeData
        {
           get
           {
               return new[]
               {
                   new object[] {1, true},
                   new object[] {21112, true},
                   new object[] {334433, true},
                   new object[] {3441443, true},
                   new object[] {47, false},
                   new object[] {2012323, false},
                   new object[] {333433, false},
                   new object[] {3441441, false},
               };
           }
        }

        // [TestMethod]
        [DynamicData(nameof(PalindromeData), DynamicDataSourceType.Property)]
        public void IsPalindrome_NaturalNumber_ReturnRight(int n, bool expectedValue)
        {
            bool actualValue = MathUtils.IsPalindrome(n);
            Assert.AreEqual(expectedValue, actualValue);
        }



        public static IEnumerable<object[]> GetPalindromeDataFromJsonFile()
        {
            string json = File.ReadAllText("test_data.json");

            List<TestData> testData = JsonSerializer.Deserialize<List<TestData>>(json);

            foreach (TestData data in testData)
            {
                yield return new object[] { data.Input, data.ExpectedOutput };
            }
        }


        //[TestMethod]
        [DynamicData(nameof(GetPalindromeDataFromJsonFile), DynamicDataSourceType.Method)]
        public void IsPalindrome_NaturalNumberGetFromJsonFile_ReturnRight(int n, bool expectedValue)
        {
            bool actualValue = MathUtils.IsPalindrome(n);
            Assert.AreEqual(expectedValue, actualValue);
        }

        private class TestData
        {
            public int Input { get; set; }
            public bool ExpectedOutput { get; set; }
        }
    }
}