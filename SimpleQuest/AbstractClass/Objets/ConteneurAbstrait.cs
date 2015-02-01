using System;
using System.Collections.Generic;

namespace SimpleQuest
{
	public abstract class ConteneurAbstrait : ObjetAbstrait
	{
		List<ObjetAbstrait> objets;

		bool vérouiller;
		int crochetageRequis;
	}
}

