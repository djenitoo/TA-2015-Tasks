using System;
using _04._AppearanceCount;
using _01._MethodHelloName;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04._Test
{
    [TestClass]
    public class TestAppearance
    {
        
        public void TestCheckAppearanceMethod()
        {
            //int appearanceC = AppearanceCount.CheckAppearance(new int[]{1,2,3,4,3,2,1,4}, 3);
            //if (AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4 }, 3) != 2)
            //{
                
            //}
            Assert.AreEqual(2, AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4 }, 3), "Answer is not equal to 2!");
            Assert.AreEqual(0, AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4 }, 5), "Answer is not equal to 0!");
            Assert.AreEqual(1, AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 6, 10 }, 6), "Answer is not equal to 1!");

            //if (AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4 }, 3) != 2 ||
            //    AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4 }, 5) != 0 ||
            //    AppearanceCount.CheckAppearance(new int[] { 1, 2, 3, 4, 3, 2, 1, 4, 6, 10 }, 6) != 1)
            //{
            //    return "Fail";
            //}
            //else
            //{
            //    return "Success";
            //}
        }

        
        public void TestHelloName()
        {
            Assert.AreEqual("Hello, Peter!", HelloName.Name("Peter"), "Not equal names!");
            Assert.AreEqual("Hello, Jenny!", HelloName.Name("Jenny"), "Not equal names!");
            //if (HelloName.Name("Jenny") != "Hello, Jenny!" || HelloName.Name("Peter") != "Hello, Peter!")
            //{
            //    return "Fail";
            //}
            //else
            //{
            //    return "Success";
            //}
        }

        
    }
}
