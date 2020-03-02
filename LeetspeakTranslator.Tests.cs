using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTests
  {
    [TestMethod]
    public void Translate_ConvertsStringInput_String()
    {
      string stringOutput = "hll";
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual(stringOutput, translator.Translate("hll"));
    }
    [TestMethod]
    public void Translate_ConvertsStringInput_StringOutputChangeE()
    {
      string stringOutput = "h3ll";
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual(stringOutput, translator.Translate("hell"));
    }
    [TestMethod]
    public void Translate_ConvertsStringInput_StringOutputChangeO()
    {
      string stringOutput = "h3ll0";
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual(stringOutput, translator.Translate("hello"));
    }
    [TestMethod]
    public void Translate_ConvertsStringInput_StringOutputChangeI()
    {
      string stringOutput = "1 d0";
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual(stringOutput, translator.Translate("I do"));
    }
    [TestMethod]
    public void Translate_ConvertsStringInput_StringOutputChangeT()
    {
      string stringOutput = "L37 g0";
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual(stringOutput, translator.Translate("Let go"));
    }
    [TestMethod]
    public void Translate_ConvertsStringInput_StringOutputChangeS()
    {
      string stringOutput = "s0 l37z g0";
      LeetspeakTranslator translator = new LeetspeakTranslator();
      Assert.AreEqual(stringOutput, translator.Translate("so lets go"));
    }  
  }
}