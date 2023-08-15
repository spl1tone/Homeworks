using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homeworks
{
    [TestClass]
    internal class BooksTest
    {

        [TestMethod]
        public void TestValidBook ()
        {
            Books book = new Books(1, "BookName", "Title", "Author", 100, 2023);

            Assert.AreEqual(1, book.IdBook);
            Assert.AreEqual("BookName", book.BookName);
            Assert.AreEqual("Title", book.Title);
            Assert.AreEqual("Author", book.Author);
            Assert.AreEqual(100, book.Price);
            Assert.AreEqual(2023, book.Year);
        }

        [TestMethod]
        public void TestInvalidId ()
        {
            Books book = new Books();

            book.IdBook = -1;

            Assert.AreEqual(0, book.IdBook);
        }

        [TestMethod]
        public void TestInvalidYear ()
        {
            Books book = new Books();

            book.Year = 2024;

            Assert.AreEqual(0, book.Year);
        }

    }
}
