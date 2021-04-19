﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ExceptionDivision))]
        public void DiviserTest()
        {
            //Arrange
            int numerateur = 5;
            int denominateur = 0;

            //Act
            Tools.diviser(numerateur, denominateur);

            //Assert
            //rien on attend juste une exception

        }
    }
}