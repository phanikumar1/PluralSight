using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluralSight;

namespace PluralSightTestProject
{
	[TestClass]
	public class PackageInstallerTests
	{
		[TestMethod]
		public void TestPackageInstallerOrder_SimpleInput_Success()
		{
			const string testInput1 = "KittenService:CamelCaser";
			const string testInput2 = "CamelCaser:";
			var input = new[] {testInput1, testInput2};
			var packageOrder = PackageInstaller.GetPackageInstallationOrder(input);
			Assert.AreEqual("CamelCaser,KittenService", packageOrder);
		}
	}
}
