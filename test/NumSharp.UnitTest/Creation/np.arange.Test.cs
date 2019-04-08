﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NumSharp.Extensions;
using System.Linq;
using NumSharp;

namespace NumSharp.UnitTest.Creation
{
    [TestClass]
    public class NumPyArangeTest
    {
        [TestMethod]
        public void arange()
        {
            var n = np.arange(3);
            Assert.IsTrue(Enumerable.SequenceEqual(n.Data<int>(), new int[] { 0, 1, 2 }));

            n = np.arange(3, 7);
            Assert.IsTrue(Enumerable.SequenceEqual(n.Data<int>(), new int[] { 3, 4, 5, 6 }));

            n = np.arange(3.0, 7.0, 2.0);
            Assert.IsTrue(Enumerable.SequenceEqual(n.Data<double>(), new double[] { 3, 5 }));

            n = np.arange(0, 11, 3);
            Assert.IsTrue(Enumerable.SequenceEqual(n.Data<int>(), new int[] { 0, 3, 6, 9 }));

            // Test increments < 1
            var startd = 0.0;
            var stopd = 12.0;
            var incrementd = 0.1;
            n = np.arange(startd, stopd, incrementd);
            var r = n.Data<double>();
            var t = Enumerable.Repeat(0, (int)((stopd - startd) / incrementd)).Select((tr, ti) => tr + incrementd * ti);
            Assert.IsTrue(r.Length == 120);
            Assert.IsTrue(Enumerable.SequenceEqual(r, t));
        }
    }
}
