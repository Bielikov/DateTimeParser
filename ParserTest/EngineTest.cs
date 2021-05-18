using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parser;

namespace ParserTest
{
    [TestClass]
    public class EngineTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            Engine engine = new Engine(new LocaleResource());
            string expected = "gg/JJJJ/FF";
            Assert.AreEqual(expected, engine.Parser(Format.Date, "en_US", "dd/YYYY/MM"));
        }
    }
}
