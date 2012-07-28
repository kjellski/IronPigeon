﻿namespace IronPigeon.Tests {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using NUnit.Framework;

	[TestFixture]
	public class DesktopCryptoProviderTests {
		[Test]
		public void HashAlgorithmName() {
			var provider = new DesktopCryptoProvider();
			Assert.That(provider.HashAlgorithmName, Is.EqualTo("SHA1")); // default
			provider.HashAlgorithmName = "SHA256";
			Assert.That(provider.HashAlgorithmName, Is.EqualTo("SHA256"));
		}
	}
}
