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
            obj.refresh(form);
            for (int i = 1; i < 10; i++ )
                obj.game(i,form);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int j=0;
            int[] a = new int[10];
            for (int i = 0; i < 9; i++) a[i] = i + 1;
            Random rnd1 = new Random();
            Form1 form = new Form1();
            Form1.Game obj = new Form1.Game();
            obj.refresh(form);
            for (int i = 1; i < 10; i++)
            {
                j = rnd1.Next(a[i-1], 11-i);
                obj.game(a[j-1], form);
                for (int k = j; k < 9; k++)
                    a[j-1] = a[j];
                obj.who_vin(form);
            }
        }
    }
}
