namespace UnitTests
{
    using System;
    using System.Diagnostics;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using WingtipToys.Logic;
    using WingtipToys.Models;

    [TestClass]
    public class AddProductTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var mockProduct = new Product
                                      {
                                          ProductName = "test product 1",
                                          CategoryID = -3,
                                          UnitPrice = 1.0,
                                          ImagePath = "fakepath",
                                          Description = "Test product. Test!"
                                      };

                var products = new AddProducts();
                var addSuccess = products.AddProduct(
                    mockProduct.ProductName,
                    mockProduct.Description,
                    mockProduct.UnitPrice.ToString(),
                    mockProduct.CategoryID.ToString(),
                    "");
                if (addSuccess)
                {
                    Debug.WriteLine("Тест добавления продукта успешен.");
                }
                else
                {
                    throw new InternalTestFailureException("Тест добавления продукта не успешен");
                }
            }
            catch (Exception ex)
            {
                throw new InternalTestFailureException(string.Format("Во вермя выполнения теста произошла ошибка {0}", ex.Message));
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
           ExceptionUtility.LogException(new InvalidCastException(),"Test of exception logging" );
        }
    }
}
