﻿namespace IronPigeon.Tests {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using NUnit.Framework;

	[TestFixture]
	public class PayloadReferenceTests {
		[Test]
		public void CtorInvalidInputs() {
			Assert.Throws<ArgumentNullException>(() => new PayloadReference(null, Valid.Hash, Valid.Key, Valid.IV, Valid.ExpirationUtc));
			Assert.Throws<ArgumentNullException>(() => new PayloadReference(Valid.Location, null, Valid.Key, Valid.IV, Valid.ExpirationUtc));
			Assert.Throws<ArgumentNullException>(() => new PayloadReference(Valid.Location, Valid.Hash, null, Valid.Key, Valid.ExpirationUtc));
			Assert.Throws<ArgumentNullException>(() => new PayloadReference(Valid.Location, Valid.Hash, Valid.Key, null, Valid.ExpirationUtc));
			Assert.Throws<ArgumentException>(() => new PayloadReference(Valid.Location, Valid.Hash, Valid.Key, Valid.IV, Invalid.ExpirationUtc));
			Assert.Throws<ArgumentException>(() => new PayloadReference(Valid.Location, Invalid.Hash, Valid.Key, Valid.IV, Valid.ExpirationUtc));
			Assert.Throws<ArgumentException>(() => new PayloadReference(Valid.Location, Valid.Hash, Invalid.Key, Valid.IV, Valid.ExpirationUtc));
			Assert.Throws<ArgumentException>(() => new PayloadReference(Valid.Location, Valid.Hash, Valid.Key, Invalid.IV, Valid.ExpirationUtc));
		}

		[Test]
		public void Ctor() {
			var reference = new PayloadReference(Valid.Location, Valid.Hash, Valid.Key, Valid.IV, Valid.ExpirationUtc);
			Assert.That(reference.Location, Is.SameAs(Valid.Location));
			Assert.That(reference.Hash, Is.SameAs(Valid.Hash));
			Assert.That(reference.Key, Is.SameAs(Valid.Key));
			Assert.That(reference.IV, Is.SameAs(Valid.IV));
			Assert.That(reference.ExpiresUtc, Is.EqualTo(Valid.ExpirationUtc));
		}
	}
}
