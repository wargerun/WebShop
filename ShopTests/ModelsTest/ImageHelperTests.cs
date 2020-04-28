using System.Collections.Generic;
using System.Linq;
using AutoMig;
using NUnit.Framework;

namespace ShopTests.ModelsTest
{
    public class ImageHelperTests
    {
        [Test]
        public void GetBytesFromImageTests()
        {
            const string filePath = @"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.jpg";

            IEnumerable<byte> bytesFromImage = ImageHelper.GetBytesFromImage(filePath);
            
            Assert.AreEqual(new byte[] { 0xFF, 0xD8, 0xFF, 0xE0}, bytesFromImage.Take(4));
        }
    }
}