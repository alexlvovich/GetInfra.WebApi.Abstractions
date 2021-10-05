using FluentAssertions;
using GetInfra.WebApi.Abstractions.Extentions;
using GetInfra.WebApi.Abstractions.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using Xunit;

namespace Getinfra.Webapi.Abstractions.Tests
{
    public class GenericResultResponseTests
    {
        [Fact]
        public void Basic_SerilizeWithout()
        {
            var result = new GenericResultResponse<bool>();
            result.Id = true;

            // act
            var str = result.AsJson<bool>();

            // assert
            str.Any(char.IsUpper).Should().BeFalse();
            str.Contains("null").Should().BeFalse();
        }
    }
}
