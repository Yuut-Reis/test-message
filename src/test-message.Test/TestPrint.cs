using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory]
    [InlineData("", "")]
    public void TestPrintMsgSucess(string Send, string Expected)
    {
        throw new NotImplementedException();
        /*using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            Message.PrintMsg("");

            string result = NewOutput.ToString().Trim();

            result.Should();      
        }*/
    }
}