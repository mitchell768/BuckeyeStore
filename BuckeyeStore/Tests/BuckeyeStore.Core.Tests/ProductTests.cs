using System;
using Xunit;

namespace BuckeyeStore.Core.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Test1()
        {
            var product = new Product{
                Id=1,
                Name="T-Shirt",
                Brand="Nike"
            };

            var review = new Review{
                Id=1,
                Body="A durable Buckeye T-shirt."
            };

            product.AddReview(review);

            Assert.NotNull(product.Review);
            Assert.Equal(review.Id, product.Review.Id);
            Assert.Equal(review.Body, product.Review.Body);
        }
    }
}
