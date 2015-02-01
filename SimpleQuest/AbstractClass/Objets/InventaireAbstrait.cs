using System;
using System.Collections.Generic;

namespace SimpleQuest
{
	public class InventaireAbstrait : ObjetAbstrait
	{
		List<ObjetAbstrait> objets;
		int emplacementMaximum;
	}
}

