using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            var test = new Program();
            string[] help_in_string = new string[10] { "-k", "key-1", "value1", "/Help", "-help", "fgfg", "-ping", "/heldf", "-k", "fg" };
            Program.Main(help_in_string);

            string[] help_not_in_string = new string[11] { "-k", "key-1", "value1", "-print", "Test", "string", "fgfg", "-ping", "/heldf", "-k", "fg" };
            Program.Main(help_not_in_string);
        }
    }
}