using System;
using WorkingWithVisualStudio.Models;
using Xunit;

namespace WorkingWithVisualStudio.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            var p = new Product { Name = "Test", Price = 100M };

            p.Name = "Nowa nazwa";

            Assert.Equal("Nowa nazwa", p.Name);
        }

        [Fact]
        public void CanChangeProductPrice()
        {
            var p = new Product { Name = "Test", Price = 100M };

            p.Price = 200M;

            Assert.Equal(200M, p.Price);
        }
    }
}
