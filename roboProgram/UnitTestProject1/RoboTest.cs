using Microsoft.VisualStudio.TestTools.UnitTesting;
using robo;

namespace RoboTestProject
{
    [TestClass]
    public class RoboTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            robo.robo roboToTest = new robo.robo();
            var t = typeof(robo.robo);

            //t.InvokeMember("getAddress",
                //BindingFlags.InvokeMethod | BindingFlags.NonPublic |
                //BindingFlags.Public | BindingFlags.Instance,
                //null, obj, null);
        }
    }
}
