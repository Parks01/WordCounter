using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordAndCounter.Models;
using System;

namespace WordAndCounter.Tests
{
  [TestClass]
  public class WordCounter
  {


    [TestMethod]
  public Class WordCounterTests_SetMainWord_Void()
  {
    //Arrange
          string expected = "hello world";
          //Act
          FindReplace.SetMainArticle("hello world");
          string actual = FindReplace.GetMainArticle();
          //Assert
          Assert.AreEqual(expected, actual);


  }
}
