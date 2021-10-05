using FluentAssertions;
using GetInfra.WebApi.Abstractions;
using GetInfra.WebApi.Abstractions.Extentions;
using GetInfra.WebApi.Abstractions.Models;
using GetInfra.WebApi.Abstractions.Models.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            result.Result = true;

            // act
            var str = result.AsJson<bool>();

            // assert

            str.Any(char.IsUpper).Should().BeFalse();
            str.Contains("null").Should().BeFalse();
        }


        [Fact]
        public void Basic_IsValid()
        {
            // act
            var result = new GenericResultResponse<bool>();
            result.Result = true;
            // assert

            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Basic_NotValid()
        {
            // act
            var result = new GenericResultResponse<bool>();
            result.Result = true;
            result.ValidationErrors = new List<ValidationErrorItem>();
            result.ValidationErrors.Add(new ValidationErrorItem("object", ""));
            // assert

            result.IsValid.Should().BeFalse();
        }


        [Fact]
        public void Basic_IsSuccess()
        {
            // act
            var result = new GenericResultResponse<bool>();
            result.Result = true;
            // assert

            result.Succeeded.Should().BeTrue();
        }

        [Fact]
        public void Basic_NoSuccess()
        {
            // act
            var result = new GenericResultResponse<bool>();
            result.Result = true;
            result.ValidationErrors = new List<ValidationErrorItem>();
            result.ValidationErrors.Add(new ValidationErrorItem("object", ""));

            result.Errors = new List<ErrorItem>();
            result.Errors.Add(new ErrorItem("object", "stack"));
            // assert

            result.Succeeded.Should().BeFalse();
        }


    }
}
