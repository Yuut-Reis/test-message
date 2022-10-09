using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory(DisplayName = "Testando se a função Printmsg imprime a menssagem corretamente no Terminal.")]
    [InlineData("Estamos sempre em busca da nossa melhor versão!", "Estamos sempre em busca da nossa melhor versão!")]
    [InlineData("Aplicando testes com xUnit", "Aplicando testes com xUnit")]
    [InlineData("C# é uma linguagem incrivel", "C# é uma linguagem incrivel")]
    [InlineData("Meu console está funcionando corretamente", "Meu console está funcionando corretamente")]
    [InlineData("Não fique triste eu te consolo", "Não fique triste eu te consolo")]
    public void TestPrintMsgSucess(string Send, string Expected)
    {
          using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            Message.PrintMsg(Send);

            string result = NewOutput.ToString().Trim();

            result.Should().Be(Expected);      
        }
    }
}