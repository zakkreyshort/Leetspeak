using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTests
  {
   [TestMethod]
   public void Translate_SplitsStringIntoArray_Array()
   {
     char[] array = { 'h', 'l', 'l' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("hll"));
   }
   [TestMethod]
   public void Translate_SplitsStringIntoArray_ArrayChangeE()
   {
     char[] array = { 'h', '3', 'l', 'l' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("hell"));
   }
   [TestMethod]
   public void Translate_SplitsStringIntoArray_ArrayChangeO()
   {
     char[] array = { 'h', '3', 'l', 'l', '0' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("hello"));
   }
   [TestMethod]
   public void Translate_SplitsStringIntoArray_ArrayChangeI()
   {
     char[] array = { '1', ' ', 'd', '0' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("I do"));
   }
    [TestMethod]
   public void Translate_SplitsStringIntoArray_ArrayChangeT()
   {
     char[] array = { 'L', '3', '7', 's', ' ', 'g', '0' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("Lets go"));
   }  
  }
}