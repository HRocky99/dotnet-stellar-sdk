﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stellar_dotnetcore_sdk.xdr;

namespace stellar_dotnetcore_unittest.xdr
{
    [TestClass]
    public class PaddingTest
    {
        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void TestString()
        {
            byte[] bytes = {0, 0, 0, 2, (byte) 'a', (byte) 'b', 1, 0};

            try
            {
                var xdrObject = String32.Decode(new XdrDataInputStream(bytes));
            }
            catch (IOException expectedException)
            {
                Assert.AreEqual("non-zero padding", expectedException.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void TestVarOpaque()
        {
            byte[] bytes = {0, 0, 0, 2, (byte) 'a', (byte) 'b', 1, 0};
            try
            {
                var xdrObject = DataValue.Decode(new XdrDataInputStream(bytes));
            }
            catch (IOException expectedException)
            {
                Assert.AreEqual("non-zero padding", expectedException.Message);
                throw;
            }
        }
    }
}