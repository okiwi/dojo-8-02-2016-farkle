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
		public void CanThrowSixDice ()
		{
			// arrange
			var scoreCalculator = new ScoreCalculator ();

			// act
			List<int> rollValues = scoreCalculator.ThrowDice ();

			// assert
			Assert.AreEqual (6, rollValues.Count);
		}

		[Test()]
		public void ThrowDoesntHaveOneOrFive(){
			// arrange
			var scoreCalculator = new ScoreCalculator ();

			// act
			var rollValues = new List<int>  { 3, 2, 2, 4, 3, 6 };

			// assert
			Assert.IsFalse (scoreCalculator.RollHasOneOrFive(rollValues));
		}

		[Test()]
		public void ThrowHasOne(){
			// arrange
			var scoreCalculator = new ScoreCalculator ();

			// act
			var rollValues = new List<int>  { 1, 2, 2, 4, 3, 6 };

			// assert
			Assert.IsTrue (scoreCalculator.RollHasOneOrFive(rollValues));
		}

		[Test()]
		public void ThrowHasFive(){
			// arrange
			var scoreCalculator = new ScoreCalculator ();

			// act
			var rollValues = new List<int>  { 5, 2, 2, 4, 3, 6 };

			// assert
			Assert.IsTrue (scoreCalculator.RollHasOneOrFive(rollValues));
		}

		[Test()]
		public void ThrowHasATriple(){
			// arrange
			var scoreCalculator = new ScoreCalculator ();

			// act
			var rollValues = new List<int>  { 2, 2, 2, 4, 3, 6 };

			// assert
			Assert.IsTrue (scoreCalculator.RollHasTriple(rollValues));
		}
		
		[Test()]
		public void ThrowHasASextet(){
			// arrange
			var scoreCalculator = new ScoreCalculator ();

			// act
			var rollValues = new List<int>  { 2, 2, 2, 2, 2, 2 };

			// assert
			Assert.IsTrue (scoreCalculator.RollHasSextet(rollValues));
		}
	}
}
