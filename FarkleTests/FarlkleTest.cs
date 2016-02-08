using NUnit.Core;
using NUnit.Framework;
using System;
using Farkle;
using System.Collections.Generic;

namespace FarkleTests
{
	[TestFixture()]
	public class FarkleTest
	{
		[Test()]
		public void CanRollFirstSixDice ()
		{
			// arrange
			var game = new FarkleGame ();

			// act
			List<int> rollValues = game.RollDice ();

			// assert
			Assert.AreEqual (6, rollValues.Count);


		}
	}
}

