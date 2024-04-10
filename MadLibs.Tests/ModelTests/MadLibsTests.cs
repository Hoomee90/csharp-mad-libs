using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadLibs.Models;

namespace MadLibs.Tests
{
	[TestClass]
	public class MadLibTests
	{
		[TestMethod]
		public void MadLibConstructor_CreateInstanceOfMadLib_MadLib()
		{
			MadLib newMadLib = new(new[] {"ordinary"});
			Assert.AreEqual(typeof(MadLib), newMadLib.GetType());
		}
		
		[TestMethod]
		public void GetWords_ReturnsWords_StringArray()
		{
			string[] words = {"plushy", "wish", "shining", "overcome"};
			MadLib newMadLib = new(words);
			string[] result = newMadLib.Words;
			Assert.AreEqual(words, result);
		}
		
		[TestMethod]
		public void SetWords_SetsValueOfWords_Void()
		{
			MadLib newMadLib = new(new[] {"plushy", "wish", "shining", "overcome"});
			string[] newWords = {"fight", "food chain", "cursed", "despairing"};
			newMadLib.Words = newWords;
			Assert.AreEqual(newWords, newMadLib.Words);
		}
	}
}