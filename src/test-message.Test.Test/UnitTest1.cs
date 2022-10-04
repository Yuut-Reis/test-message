using Xunit;
using FluentAssertions;
using System;
using test_message.Test;

namespace test_message.Test.Test;

[Collection("Sequential")]
public class UnitTest1
{
    [Trait("Category", "1 - Criou testes de sucesso para o TestPrintMsgSucess.")]
    [Theory(DisplayName = "TestPrintMsgSucess deve ser executado com entradas corretas")]
    [InlineData("olá", "olá")]
    [InlineData("teste", "teste")]
    [InlineData("mensagem", "mensagem")]
    [InlineData("hello world", "hello world")]
    [InlineData("alguma coisa\n alguma coisa", "alguma coisa\n alguma coisa")]
    public void TestSucessTestPrintMsgSucess(string Entry, string Expected)
    {
        TestPrint instance = new();
        Action act = () => instance.TestPrintMsgSucess(Entry, Expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class UnitTest2 {
    [Trait("Category", "2 - Criou testes de falha para o TestPrintMsgSucess.")]
    [Theory(DisplayName = "TestPrintMsgSucess deve falhar com entradas erradas")]
    [InlineData("ola", "olá")]
    [InlineData("teste1", "teste")]
    [InlineData("mensagem2", "mensagem")]
    [InlineData("hello world3", "hello world")]
    [InlineData("alguma coisa4\n alguma coisa", "alguma coisa\n alguma coisa")]
    public void TestFailTestOlaMundo(string Entry, string Expected)
    {
        TestPrint instance = new();
        Action act = () => instance.TestPrintMsgSucess(Entry, Expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
