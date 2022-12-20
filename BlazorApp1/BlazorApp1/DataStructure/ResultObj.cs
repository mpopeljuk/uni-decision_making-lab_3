namespace BlazorApp1.DataStructure;

public class ResultObj
{
	public int Id { get; set; }

	public string DisplayValue { get; set; }

	public Dictionary<Features, int> FeaturesScore = new Dictionary<Features, int>();
	
	/// <summary>
	/// List of features that are required for the answer to be available.
	/// </summary>
	public List<Features> RequiredFeatures { get; set; } = new List<Features>();
	
	/// <summary>
	/// List of features that rules out this answer from available.
	/// </summary>
	public List<Features> RulesOutFeatures { get; set; } = new List<Features>();
}

public class ResultsObjService
{
	public static List<ResultObj> AllResults => new List<ResultObj>
	{
		new ResultObj
		{
			Id = 0,
			DisplayValue = "Буковель (катання на лижах/борді)",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 10 },
				{ Features.MediumDistance, 5 },
				{ Features.Mountain, 10 },
				{ Features.Active, 10 },
				{ Features.Extreme, 7 },
				{ Features.ColdClimate, 10 },
				{ Features.MediumPrice, 3 },
				{ Features.HighPrice, 7 },
				{ Features.Safe, 7 },
				{ Features.Dangerous, 2 },
				{ Features.InsideCountry, 10 },
				{ Features.Comfortable, 5 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, -5 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 10 },
				{ Features.MiddleAge, 4 },
				{ Features.OldAge, 0 },
				{ Features.LongVacation, 0 },
				{ Features.ShortVacation, 7 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.Active,
				Features.Mountain
			},
			RulesOutFeatures = new List<Features>
			{
				Features.Lazy,
				Features.Sea
			}
		},
		new ResultObj
		{
			Id = 1,
			DisplayValue = "Буковель (готель + СПА)",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 10 },
				{ Features.MediumDistance, 5 },
				{ Features.FarDistance, 0 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 10 },
				{ Features.EuropeCity, 0 },
				{ Features.Lazy, 10 },
				{ Features.Active, 0 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 10 },
				{ Features.HotClimate, 0 },
				{ Features.CheapPrice, 0 },
				{ Features.MediumPrice, 7 },
				{ Features.HighPrice, 3 },
				{ Features.Safe, 10 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 10 },
				{ Features.Abroad, 0 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 10 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, -5 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 0 },
				{ Features.MiddleAge, 0 },
				{ Features.OldAge, 0 },
				{ Features.LongVacation, 0 },
				{ Features.ShortVacation, 7 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.Lazy,
				Features.Mountain
			},
			RulesOutFeatures = new List<Features>
			{
				Features.Extreme,
				Features.Sea
			}
		},
		new ResultObj
		{
			Id = 2,
			DisplayValue = "Майорка (готель + дослідження острову)",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 10 },
				{ Features.Continental, 0 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 3 },
				{ Features.FarDistance, 7 },
				{ Features.Sea, 10 },
				{ Features.Mountain, 5 },
				{ Features.EuropeCity, 3 },
				{ Features.Lazy, 0 },
				{ Features.Active, 10 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 5 },
				{ Features.HotClimate, 7 },
				{ Features.CheapPrice, 0 },
				{ Features.MediumPrice, 4 },
				{ Features.HighPrice, 7 },
				{ Features.Safe, 10 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 2 },
				{ Features.Comfortable, 8 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, -5 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 10 },
				{ Features.MiddleAge, 7 },
				{ Features.OldAge, 3 },
				{ Features.LongVacation, 6 },
				{ Features.ShortVacation, 0 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.AeroOk,
			},
			RulesOutFeatures = new List<Features>
			{
				Features.Aerophobia,
			}
		},
		new ResultObj
		{
			Id = 3,
			DisplayValue = "Круїз на лайнері",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 0 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 0 },
				{ Features.FarDistance, 10 },
				{ Features.Sea, 10 },
				{ Features.Mountain, 0 },
				{ Features.EuropeCity, 3 },
				{ Features.Lazy, 5 },
				{ Features.Active, 2 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 5 },
				{ Features.HotClimate, 7 },
				{ Features.CheapPrice, 0 },
				{ Features.MediumPrice, 2 },
				{ Features.HighPrice, 8 },
				{ Features.Safe, 7 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 10 },
				{ Features.ShipCrouise, 10 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 3 },
				{ Features.MiddleAge, 5 },
				{ Features.OldAge, 10 },
				{ Features.LongVacation, 10 },
				{ Features.ShortVacation, 0 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.ShipOk,
			},
			RulesOutFeatures = new List<Features>
			{
				Features.SeaSickness,
			}
		},
		new ResultObj
		{
			Id = 4,
			DisplayValue = "Шрі-Ланка",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 10 },
				{ Features.Continental, 0 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 0 },
				{ Features.FarDistance, 10 },
				{ Features.Sea, 10 },
				{ Features.Mountain, 0 },
				{ Features.EuropeCity, 0 },
				{ Features.Lazy, 5 },
				{ Features.Active, 2 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 0 },
				{ Features.HotClimate, 10 },
				{ Features.CheapPrice, 0 },
				{ Features.MediumPrice, 5 },
				{ Features.HighPrice, 5 },
				{ Features.Safe, 6 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 7 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 4 },
				{ Features.MiddleAge, 8 },
				{ Features.OldAge, 5 },
				{ Features.LongVacation, 7 },
				{ Features.ShortVacation, 0 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.AeroOk,
			},
			RulesOutFeatures = new List<Features>
			{
				Features.Aerophobia,
			}
		},
		new ResultObj
		{
			Id = 5,
			DisplayValue = "Схід на Eверест",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 3 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 0 },
				{ Features.FarDistance, 10 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 10 },
				{ Features.EuropeCity, 0 },
				{ Features.Lazy, 0 },
				{ Features.Active, 10 },
				{ Features.Extreme, 10 },
				{ Features.ColdClimate, 10 },
				{ Features.MildClimate, 0 },
				{ Features.HotClimate, 0 },
				{ Features.CheapPrice, 0 },
				{ Features.MediumPrice, 0 },
				{ Features.HighPrice, 10 },
				{ Features.Safe, 0 },
				{ Features.Dangerous, 10 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 10 },
				{ Features.Comfortable, 0 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 0 },
				{ Features.MiddleAge, 10 },
				{ Features.OldAge, 0 },
				{ Features.LongVacation, 10 },
				{ Features.ShortVacation, 0 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.Extreme,
			},
			RulesOutFeatures = new List<Features>
			{
				Features.Lazy,
				Features.Aerophobia
			}
		},
		new ResultObj
		{
			Id = 6,
			DisplayValue = "Поїздка у Львів",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 7 },
				{ Features.FarDistance, 0 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 0 },
				{ Features.EuropeCity, 10 },
				{ Features.Lazy, 5 },
				{ Features.Active, 5 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 10 },
				{ Features.HotClimate, 0 },
				{ Features.CheapPrice, 7 },
				{ Features.MediumPrice, 4 },
				{ Features.HighPrice, 0 },
				{ Features.Safe, 10 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 10 },
				{ Features.Abroad, 0 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 8 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 5 },
				{ Features.MiddleAge, 5 },
				{ Features.OldAge, 5 },
				{ Features.LongVacation, 0 },
				{ Features.ShortVacation, 7 }
			},
			RequiredFeatures = new List<Features>(),
			RulesOutFeatures = new List<Features>()
		},
		new ResultObj
		{
			Id = 7,
			DisplayValue = "Поїздка у Відень",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 7 },
				{ Features.FarDistance, 0 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 3 },
				{ Features.EuropeCity, 10 },
				{ Features.Lazy, 5 },
				{ Features.Active, 5 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 10 },
				{ Features.HotClimate, 0 },
				{ Features.CheapPrice, 7 },
				{ Features.MediumPrice, 4 },
				{ Features.HighPrice, 0 },
				{ Features.Safe, 10 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 8 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 5 },
				{ Features.MiddleAge, 5 },
				{ Features.OldAge, 5 },
				{ Features.LongVacation, 3 },
				{ Features.ShortVacation, 7 }
			},
			RequiredFeatures = new List<Features>(),
			RulesOutFeatures = new List<Features>()
		},
		new ResultObj
		{
			Id = 8,
			DisplayValue = "Дослідження Ісландії",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 10 },
				{ Features.Continental, 0 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 0 },
				{ Features.FarDistance, 10 },
				{ Features.Sea, 5 },
				{ Features.Mountain, 5 },
				{ Features.EuropeCity, 0 },
				{ Features.Lazy, 0 },
				{ Features.Active, 10 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 4 },
				{ Features.MildClimate, 6 },
				{ Features.HotClimate, 0 },
				{ Features.CheapPrice, 2 },
				{ Features.MediumPrice, 6 },
				{ Features.HighPrice, 4 },
				{ Features.Safe, 8 },
				{ Features.Dangerous, 2 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 8 },
				{ Features.Comfortable, 2 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 7 },
				{ Features.MiddleAge, 5 },
				{ Features.OldAge, 3 },
				{ Features.LongVacation, 7 },
				{ Features.ShortVacation, 3 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.AeroOk
			},
			RulesOutFeatures = new List<Features>()
		},
		new ResultObj
		{
			Id = 9,
			DisplayValue = "Дослідження Азорських Островів",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 10 },
				{ Features.Continental, 0 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 3 },
				{ Features.FarDistance, 7 },
				{ Features.Sea, 5 },
				{ Features.Mountain, 5 },
				{ Features.EuropeCity, 0 },
				{ Features.Lazy, 0 },
				{ Features.Active, 10 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 1 },
				{ Features.MildClimate, 7 },
				{ Features.HotClimate, 3 },
				{ Features.CheapPrice, 1 },
				{ Features.MediumPrice, 7 },
				{ Features.HighPrice, 3 },
				{ Features.Safe, 9 },
				{ Features.Dangerous, 1 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 5 },
				{ Features.Comfortable, 4 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, -2 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, -2 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 7 },
				{ Features.MiddleAge, 5 },
				{ Features.OldAge, 2 },
				{ Features.LongVacation, 6 },
				{ Features.ShortVacation, 4 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.AeroOk
			},
			RulesOutFeatures = new List<Features>()
		},
		new ResultObj
		{
			Id = 10,
			DisplayValue = "Відпустка у Парижі",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 7 },
				{ Features.FarDistance, 3 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 2 },
				{ Features.EuropeCity, 10 },
				{ Features.Lazy, 5 },
				{ Features.Active, 5 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 1 },
				{ Features.MildClimate, 7 },
				{ Features.HotClimate, 1 },
				{ Features.CheapPrice, 1 },
				{ Features.MediumPrice, 8 },
				{ Features.HighPrice, 3 },
				{ Features.Safe, 9 },
				{ Features.Dangerous, 1 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 10 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 7 },
				{ Features.MiddleAge, 10 },
				{ Features.OldAge, 10 },
				{ Features.LongVacation, 4 },
				{ Features.ShortVacation, 6 }
			},
			RequiredFeatures = new List<Features>
			{
				Features.AeroOk
			},
			RulesOutFeatures = new List<Features>()
		},
		new ResultObj
		{
			Id = 11,
			DisplayValue = "Відвідай Київ",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 2 },
				{ Features.MediumDistance, 8 },
				{ Features.FarDistance, 0 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 2 },
				{ Features.EuropeCity, 10 },
				{ Features.Lazy, 6 },
				{ Features.Active, 4 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 3 },
				{ Features.MildClimate, 7 },
				{ Features.HotClimate, 1 },
				{ Features.CheapPrice, 6 },
				{ Features.MediumPrice, 8 },
				{ Features.HighPrice, 2 },
				{ Features.Safe, 7 },
				{ Features.Dangerous, 3 },
				{ Features.InsideCountry, 10 },
				{ Features.Abroad, 0 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 8 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 7 },
				{ Features.MiddleAge, 10 },
				{ Features.OldAge, 6 },
				{ Features.LongVacation, 2 },
				{ Features.ShortVacation, 8 }
			},
			RequiredFeatures = new List<Features>(),
			RulesOutFeatures = new List<Features>()
		},
		new ResultObj
		{
			Id = 12,
			DisplayValue = "Шик в Дубаях",
			FeaturesScore = new Dictionary<Features, int>
			{
				{ Features.Island, 0 },
				{ Features.Continental, 10 },
				{ Features.SmallDistance, 0 },
				{ Features.MediumDistance, 8 },
				{ Features.FarDistance, 2 },
				{ Features.Sea, 0 },
				{ Features.Mountain, 0 },
				{ Features.EuropeCity, 0 },
				{ Features.Lazy, 8 },
				{ Features.Active, 2 },
				{ Features.Extreme, 0 },
				{ Features.ColdClimate, 0 },
				{ Features.MildClimate, 2 },
				{ Features.HotClimate, 10 },
				{ Features.CheapPrice, 0 },
				{ Features.MediumPrice, 2 },
				{ Features.HighPrice, 10 },
				{ Features.Safe, 10 },
				{ Features.Dangerous, 0 },
				{ Features.InsideCountry, 0 },
				{ Features.Abroad, 10 },
				{ Features.Camping, 0 },
				{ Features.Comfortable, 10 },
				{ Features.ShipCrouise, 0 },
				{ Features.SeaSickness, 0 },
				{ Features.Aerophobia, 0 },
				{ Features.CarSickness, 0 },
				{ Features.AeroOk, 0 },
				{ Features.ShipOk, 0 },
				{ Features.YoungAge, 10 },
				{ Features.MiddleAge, 10 },
				{ Features.OldAge, 10 },
				{ Features.LongVacation, 0 },
				{ Features.ShortVacation, 10 }
			},
			RequiredFeatures = new List<Features>(),
			RulesOutFeatures = new List<Features>()
		},
	};
}