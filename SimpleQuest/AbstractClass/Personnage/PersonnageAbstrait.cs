using System;
using System.Collections.Generic;

namespace SimpleQuest
{
	public abstract class PersonnageAbstrait
	{
		public List<PersonnageAbstrait> équipe;

		public Dictionary<CaractéristiqueType, CaractéristiqueAbstraite> caractéristiques;
		public List<EffetAbstrait> effetsActifs;

		public Dictionary<Emplacement, ÉquipementAbstrait> équipements;
		public ArmeAbstraite armeGauche;

		public List<PersonnageType> types;

		BourseAbstraite bourse;

	}
}

