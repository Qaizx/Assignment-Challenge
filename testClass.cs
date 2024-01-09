using Main;
using Xunit;
public class testClass
{
    [Fact]
    public void CanParsingTest() => Assert.True(ParsingFunction.Parsing.CanParsing("1234#"));

    [Fact]
    public void CanNotParsingTest() => Assert.False(ParsingFunction.Parsing.CanParsing("12a34#"));

    [Fact]
    public void CanNotParsingTestDontHaveHash() => Assert.False(ParsingFunction.Parsing.CanParsing("12a34"));

    [Fact]
    public void TestParseA() => Assert.Equal("A", ParsingFunction.Parsing.ParsingInput("2"));

    [Fact]
    public void TestParseB() => Assert.Equal("B", ParsingFunction.Parsing.ParsingInput("22"));

    [Fact]
    public void TestParseC() => Assert.Equal("C", ParsingFunction.Parsing.ParsingInput("222"));

    [Fact]
    public void TestParseAIfPressedTooMuch() => Assert.Equal("A", ParsingFunction.Parsing.ParsingInput("2222"));

    [Fact]
    public void TestParseBIfPressedTooMuch() => Assert.Equal("B", ParsingFunction.Parsing.ParsingInput("22222"));

    [Fact]
    public void TestParseCIfPressedTooMuch() => Assert.Equal("C", ParsingFunction.Parsing.ParsingInput("222222"));

    [Fact]
    public void TestParseD() => Assert.Equal("D", ParsingFunction.Parsing.ParsingInput("3"));

    [Fact]
    public void TestParseE() => Assert.Equal("E", ParsingFunction.Parsing.ParsingInput("33"));

    [Fact]
    public void TestParseF() => Assert.Equal("F", ParsingFunction.Parsing.ParsingInput("333"));

    [Fact]
    public void TestParseDIfPressedTooMuch() => Assert.Equal("D", ParsingFunction.Parsing.ParsingInput("3333"));

    [Fact]
    public void TestParseEIfPressedTooMuch() => Assert.Equal("E", ParsingFunction.Parsing.ParsingInput("33333"));

    [Fact]
    public void TestParseFIfPressedTooMuch() => Assert.Equal("F", ParsingFunction.Parsing.ParsingInput("333333"));

    [Fact]
    public void TestParseG() => Assert.Equal("G", ParsingFunction.Parsing.ParsingInput("4"));

    [Fact]
    public void TestParseH() => Assert.Equal("H", ParsingFunction.Parsing.ParsingInput("44"));

    [Fact]
    public void TestParseI() => Assert.Equal("I", ParsingFunction.Parsing.ParsingInput("444"));

    [Fact]
    public void TestParseGIfPressedTooMuch() => Assert.Equal("G", ParsingFunction.Parsing.ParsingInput("4444"));

    [Fact]
    public void TestParseHIfPressedTooMuch() => Assert.Equal("H", ParsingFunction.Parsing.ParsingInput("44444"));

    [Fact]
    public void TestParseIIfPressedTooMuch() => Assert.Equal("I", ParsingFunction.Parsing.ParsingInput("444444"));

    [Fact]
    public void TestParseJ() => Assert.Equal("J", ParsingFunction.Parsing.ParsingInput("5"));

    [Fact]
    public void TestParseK() => Assert.Equal("K", ParsingFunction.Parsing.ParsingInput("55"));

    [Fact]
    public void TestParseL() => Assert.Equal("L", ParsingFunction.Parsing.ParsingInput("555"));

    [Fact]
    public void TestParseJIfPressedTooMuch() => Assert.Equal("J", ParsingFunction.Parsing.ParsingInput("5555"));

    [Fact]
    public void TestParseKIfPressedTooMuch() => Assert.Equal("K", ParsingFunction.Parsing.ParsingInput("55555"));

    [Fact]
    public void TestParseLIfPressedTooMuch() => Assert.Equal("L", ParsingFunction.Parsing.ParsingInput("555555"));

    [Fact]
    public void TestParseM() => Assert.Equal("M", ParsingFunction.Parsing.ParsingInput("6"));

    [Fact]
    public void TestParseN() => Assert.Equal("N", ParsingFunction.Parsing.ParsingInput("66"));

    [Fact]
    public void TestParseO() => Assert.Equal("O", ParsingFunction.Parsing.ParsingInput("666"));

    [Fact]
    public void TestParseMIfPressedTooMuch() => Assert.Equal("M", ParsingFunction.Parsing.ParsingInput("6666"));

    [Fact]
    public void TestParseNIfPressedTooMuch() => Assert.Equal("N", ParsingFunction.Parsing.ParsingInput("66666"));

    [Fact]
    public void TestParseOIfPressedTooMuch() => Assert.Equal("O", ParsingFunction.Parsing.ParsingInput("666666"));

    [Fact]
    public void TestParseP() => Assert.Equal("P", ParsingFunction.Parsing.ParsingInput("7"));

    [Fact]
    public void TestParseQ() => Assert.Equal("Q", ParsingFunction.Parsing.ParsingInput("77"));

    [Fact]
    public void TestParseR() => Assert.Equal("R", ParsingFunction.Parsing.ParsingInput("777"));

    [Fact]
    public void TestParseS() => Assert.Equal("S", ParsingFunction.Parsing.ParsingInput("7777"));

    [Fact]
    public void TestParsePIfPressedTooMuch() => Assert.Equal("P", ParsingFunction.Parsing.ParsingInput("77777"));

    [Fact]
    public void TestParseQIfPressedTooMuch() => Assert.Equal("Q", ParsingFunction.Parsing.ParsingInput("777777"));

    [Fact]
    public void TestParseRIfPressedTooMuch() => Assert.Equal("R", ParsingFunction.Parsing.ParsingInput("7777777"));

    [Fact]
    public void TestParseSIfPressedTooMuch() => Assert.Equal("S", ParsingFunction.Parsing.ParsingInput("77777777"));

    [Fact]
    public void TestParseT() => Assert.Equal("T", ParsingFunction.Parsing.ParsingInput("8"));

    [Fact]
    public void TestParseU() => Assert.Equal("U", ParsingFunction.Parsing.ParsingInput("88"));

    [Fact]
    public void TestParseV() => Assert.Equal("V", ParsingFunction.Parsing.ParsingInput("888"));

    [Fact]
    public void TestParseTIfPressedTooMuch() => Assert.Equal("T", ParsingFunction.Parsing.ParsingInput("8888"));

    [Fact]
    public void TestParseUIfPressedTooMuch() => Assert.Equal("U", ParsingFunction.Parsing.ParsingInput("88888"));

    [Fact]
    public void TestParseVIfPressedTooMuch() => Assert.Equal("V", ParsingFunction.Parsing.ParsingInput("888888"));

    [Fact]
    public void TestParseW() => Assert.Equal("W", ParsingFunction.Parsing.ParsingInput("9"));

    [Fact]
    public void TestParseX() => Assert.Equal("X", ParsingFunction.Parsing.ParsingInput("99"));

    [Fact]
    public void TestParseY() => Assert.Equal("Y", ParsingFunction.Parsing.ParsingInput("999"));

    [Fact]
    public void TestParseZ() => Assert.Equal("Z", ParsingFunction.Parsing.ParsingInput("9999"));

    [Fact]
    public void TestParseWIfPressedTooMuch() => Assert.Equal("W", ParsingFunction.Parsing.ParsingInput("99999"));

    [Fact]
    public void TestParseXIfPressedTooMuch() => Assert.Equal("X", ParsingFunction.Parsing.ParsingInput("999999"));

    [Fact]
    public void TestParseYIfPressedTooMuch() => Assert.Equal("Y", ParsingFunction.Parsing.ParsingInput("9999999"));

    [Fact]
    public void TestParseZIfPressedTooMuch() => Assert.Equal("Z", ParsingFunction.Parsing.ParsingInput("99999999"));

    [Fact]
    public void TestParseZero() => Assert.Equal(" ", ParsingFunction.Parsing.ParsingInput("0"));

    [Fact]
    public void TestParseZeroIfPressedTooMuch() => Assert.Equal("     ", ParsingFunction.Parsing.ParsingInput("00000"));

    [Fact]
    public void TestCAB() => Assert.Equal("CAB", Program.OldPhonePad("222 2 22#"));

    [Fact]
    public void TestE() => Assert.Equal("E", Program.OldPhonePad("33#"));

    [Fact]
    public void TestB() => Assert.Equal("B", Program.OldPhonePad("227*#"));

    [Fact]
    public void TestHELLO() => Assert.Equal("HELLO", Program.OldPhonePad("4433555 555666#"));

    [Fact]
    public void TestTURING() => Assert.Equal("TURING", Program.OldPhonePad("8 88777444666*664#"));

    [Fact]
    public void TestDeleteFront() => Assert.Equal("TURING", Program.OldPhonePad("*8 88777444666*664#"));

    [Fact]
    public void TestDeleteMultiple() => Assert.Equal("TUING", Program.OldPhonePad("*8 88777*444666*664#"));

}