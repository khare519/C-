using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqPractice;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestMoq
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllBooksForCategory_returns_list_of_available_books()
        {
            //1
            var bookServiceStub = new Mock<IBookService>();
            //2
            bookServiceStub.Setup(x => x.GetBooksForCategory("Unit Testing"))
                .Returns(new List<string>
                {
                "The Art of Unit Testing",
                "Test-Driven Development",
                "Working Effectively with Legacy Code"
                });
            //3
            var accountService = new AccountService(bookServiceStub.Object, null);
            IEnumerable<string> result = accountService.GetAllBooksForCategory("Unit Testing");
            Assert.AreEqual(3,result.Count());
        }
    }
}
