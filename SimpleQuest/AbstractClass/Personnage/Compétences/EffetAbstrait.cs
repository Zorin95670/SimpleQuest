using System;
using System.Collections.Generic;
namespace SimpleQuest
{
	public abstract class EffetAbstrait
	{
		public List<CompétenceAbstraite> compétences;
		public Dictionary<CaractéristiqueType, int> effets;
		public int tourActif;

	}
}

