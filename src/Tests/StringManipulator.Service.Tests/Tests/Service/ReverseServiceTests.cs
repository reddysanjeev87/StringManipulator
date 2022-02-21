using FluentAssertions;
using Moq;
using StringManipulator.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulator.Service.Tests.Tests
{

    public class ReverseServiceTests
    {
        public Mock<IFileWriter> fileWriter;
        public Mock<IFileReader> fileReader;

        private IReverseService sut;
        public ReverseServiceTests()
        {
            this.fileReader=new Mock<IFileReader>();
            this.fileWriter=new Mock<IFileWriter>();
            this.sut = new ReverseService(fileWriter.Object,fileReader.Object);
        }
        [Fact]
        public void reverse_should_return_empty_if_file_doesnot_have_content()
        {
            this.fileReader.Setup(x => x.Read()).Returns(string.Empty);
            var result = sut.Reverse();
            result.IsSuccess.Should().Be(false);
            result.ReverseText.Should().BeNullOrEmpty();
        }
        [Fact]
        public void reverse_should_return_ereht_olleH_if_file_have_content_Hello_there()
        {
            this.fileReader.Setup(x => x.Read()).Returns("Hello there!");
            var result = sut.Reverse();
            result.IsSuccess.Should().Be(true);
            result.ReverseText.Should().Be("!ereht olleH");
        }
       
    }
}
