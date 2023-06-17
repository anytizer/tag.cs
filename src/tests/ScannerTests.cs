using libraries;

namespace tests
{
    [TestClass]
    public class ScannerTests
    {
        [TestMethod]
        public void TestEmptyDatabase()
        {
            Scanner scanner = new Scanner();
            string backup = scanner.empty();

            Assert.AreEqual(8, backup.Length);
        }

        [TestMethod]
        public void TestMethod1()
        {
            string path = "d:\\camera";

            Scanner scanner = new Scanner();
            string[] images = scanner.list(path);

            Assert.AreEqual(158, images.Length);
        }
    }
}