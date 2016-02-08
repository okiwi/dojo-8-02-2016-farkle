using System;
using System.Collections.Generic;
using System.Linq;

namespace Farkle
{
	public class ScoreCalculator
	{
		public ScoreCalculator ()
		{
		}

		public List<int> ThrowDice(){
			return new List<int> () { 1, 2, 2, 4, 3, 6 };
		}

		public bool RollHasOneOrFive(List<int> roll) {
			return roll.Contains(1) || roll.Contains(5);
		}

		public bool RollHasTriple (List<int> rollValues)
		{
			return rollValues.GroupBy(value => value)
						     .Any (g => g.Count() == 3);
		}

		public bool RollHasSextet (List<int> rollValues)
		{
			return rollValues.GroupBy(value => value)
				.Any (g => g.Count() == 6);
		}
	}
}

