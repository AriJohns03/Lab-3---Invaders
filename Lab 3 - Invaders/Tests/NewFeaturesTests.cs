﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_3___Invaders.Tests
{
    [TestClass]
    public class NewFeaturesTests
    {
        public Rectangle FormArea { get; set; }
        Random random = new Random();

        [TestMethod]
        public void ProperLevelReturnsBossWave()
        {
            
            Game g = new Game(random, FormArea);
            Assert.AreEqual(true, g.isBossWave(2));
        }

        [TestMethod]
        public void ImproperLevelReturnsNormalWave()
        {
            Game g = new Game(random, FormArea);
            Assert.AreEqual(false, g.isBossWave(7));
        }


    }
}
