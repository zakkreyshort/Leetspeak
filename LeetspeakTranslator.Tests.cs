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
     char[] array = { 'h', 'e', 'l', 'l', 'o' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("hello"));
   }
   [TestMethod]
   public void Translate_SplitsStringIntoArray_ArrayChangeE()
   {
     char[] array = { 'h', '3', 'l', 'l', 'o' };
     LeetspeakTranslator translator = new LeetspeakTranslator();
     CollectionAssert.AreEqual(array, translator.Translate("hello"));
   }
  }
}