using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Parser;

namespace TestParser
{
    [TestFixture]
    public class TestEngine
    {
        private Engine engine;
        [TestInitialize]
        public void TestInitialize()
        {
            engine = new Engine(new LocaleResource());
        }
    }
}
