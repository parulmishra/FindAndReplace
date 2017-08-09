using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindAndReplace.Models;
using System;
namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTest
  {
    [TestMethod]
    public void FindingAndReplacing_ShouldReturnModifiedSentenceWhenAllValuesAreEnteredAMatchOccurs_String()
    {
      string expected = "My cat is cute";
      FindAndReplaceClass fr = new FindAndReplaceClass("dog", "cat", "My dog is cute");
      string actual = fr.FindingAndReplacing();
      Assert.AreEqual(expected, actual);
    }
    public void FindingAndReplacing_ShouldReturnMessageIfNoMatchFound_String()
    {
      string expected = "No match found";
      FindAndReplaceClass fr = new FindAndReplaceClass("dog", "cat", "My bird is cute");
      string actual = fr.FindingAndReplacing();
      Assert.AreEqual(expected, actual);
    }
  }
}
