using demo_mstest_swp.Models;

namespace UnitTesting
{
    [TestClass]
    public class StudentTesting
    {

        // Unit test for method GetTitleWithGPA
        [TestMethod]
        public void GetTitleWithGPA_GPAFromNineToTen_ReturnExcellent()
        {
            var student = new Student("Loc", 21, "Software Engineer", 9.5);

            var expectedValue = "Excellent";

            var acualValue = student.GetTitleWithGPA();

            Assert.AreEqual(expectedValue, acualValue);
        }

        [TestMethod]
        public void GetTitleWithGPA_GPAFromNineToTen_ReturnAverage()
        {
            var student = new Student("Loc", 21, "Software Engineer", 4.4);

            var expectedValue = "Average";

            var acualValue = student.GetTitleWithGPA();

            Assert.AreEqual(expectedValue, acualValue);
        }

        [TestMethod]
        public void GetTitleWithGPA_GreaterThanTen_ThrowsException()
        {
            var student1 = new Student("Loc", 21, "Software Engineer", 11.0);
            Assert.ThrowsException<FormatException>(() => student1.GetTitleWithGPA());

            var student2 = new Student("Loc", 21, "Software Engineer", 10.3);
            Assert.ThrowsException<FormatException>(() => student2.GetTitleWithGPA());
        }

        // Unit test for method ConvertGPAOutOfFourRoundToTens

        [TestMethod]
        public void ConvertGPAOutOfFourRoundToTens_RightFormatGPA_ReturnGPAOutOfFour()
        {
            var student = new Student("Loc", 21, "Software Engineer", 7.0);

            var expectedValue = 2.80;

            var actualValue = student.ConvertGPAOutOfFourRoundToTens();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ConvertGPAOutOfFourRoundToTens_NegativeGPA_ThrowsException()
        {
            var student1 = new Student("Loc", 21, "Software Engineer", -1.0);
            Assert.ThrowsException<FormatException>(() => student1.ConvertGPAOutOfFourRoundToTens());

            var student2 = new Student("Loc", 21, "Software Engineer", -20);
            Assert.ThrowsException<FormatException>(() => student2.ConvertGPAOutOfFourRoundToTens());
        }
    }
}