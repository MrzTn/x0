using WindowsFormsApplication1;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                Form1 form = new Form1();                
                Form1.Game obj = new Form1.Game();
                obj.refresh(form);            
        }

        [TestMethod]
        public void TestMethod2()
        {
            Form1 form = new Form1();
            Form1.Game obj = new Form1.Game();
            for (int i = 1; i < 10; i++ )
                obj.game(i,form);
        }
    }
}
