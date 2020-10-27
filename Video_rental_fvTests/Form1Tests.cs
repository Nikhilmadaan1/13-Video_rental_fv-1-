using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_fv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_fv.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            MovieStoreDataConnection instance = new MovieStoreDataConnection();
            int g = instance.calcuateCharges(2018);
            if (g == 2 || g == 5)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            MovieStoreDataConnection instance = new MovieStoreDataConnection();
            int g = instance.checkMovieStatus(1);
            if (g ==0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }



    }
}