﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;

namespace Morgengry
{

   /* [TestClass]
    public class UnitTest2
    {
        book b1, b2, b3;
        Amulet a11, a12, a13;
        Course c111, c112;
        CourseRepository courses = new CourseRepository();
        BookRepository books = new BookRepository();
        AmuletRepository amulets = new AmuletRepository();



        [TestInitialize]
        public void Init()
        {
            b1 = new book("1");
            b2 = new book("2", "Falling in Love with Yourself");
            b3 = new book("3", "Spirits in the Night", 123.55);
            books.AddBook(b1);
            books.AddBook(b2);
            books.AddBook(b3);


            a11 = new Amulet("11");
            a12 = new Amulet("12", Level.high);
            a13 = new Amulet("13", Level.low, "Capricorn");
            amulets.AddAmulet(a11);
            amulets.AddAmulet(a12);
            amulets.AddAmulet(a13);


            c111 = new Course("Eufori med røg");
            c112 = new Course("Nuru Massage using Chia Oil", 157);
            courses.AddCourse(c111);
            courses.AddCourse(c112);



        }
               
        [TestMethod]
        public void TestGetValueForBook()
        {
            Assert.AreEqual(Utility.GetValueOfMerchandise(b1), 0.0);
            Assert.AreEqual(Utility.GetValueOfMerchandise(b2), 0.0);
            Assert.AreEqual(Utility.GetValueOfMerchandise(b3), 123.55);
            Assert.AreEqual(books.GetTotalValue(), 123.55);
        }

        [TestMethod]
        public void TestGetValueForAmulet()
        {
            Assert.AreEqual(Utility.GetValueOfMerchandise(a11), 20.0);
            Assert.AreEqual(Utility.GetValueOfMerchandise(a12), 27.5);
            Assert.AreEqual(Utility.GetValueOfMerchandise(a13), 12.5);
            Assert.AreEqual(amulets.GetTotalValue(), 60.0);
        }

        [TestMethod]
        public void TestGetValueForCourse()
        {
            Assert.AreEqual(Utility.GetValueOfCourse(c111), 0.0);
            Assert.AreEqual(Utility.GetValueOfCourse(c112), 1750.0);
            Assert.AreEqual(courses.GetTotalValue(), 1750.0);
        }



    }*/


}
