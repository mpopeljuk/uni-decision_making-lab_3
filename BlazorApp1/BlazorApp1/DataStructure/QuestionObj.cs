namespace BlazorApp1.DataStructure;

public class QuestionObj
{
	public int Id { get; set; }

	public string DisplayValue { get; set; }

	public List<Features> RequiredFeatures { get; set; } = new List<Features>();

	public Func<string, Features> GetFeatureResult { get; set; }
}

public class QuestionObjService
{
	public static List<QuestionObj> AllQuestions => new List<QuestionObj>
	{
		new QuestionObj
		{
			Id = 1,
			DisplayValue = "Скільки у вас днів на відпустку?",
			GetFeatureResult = (x) =>
			{
				var val = int.Parse(x);
				if (val < 5) return Features.ShortVacation;
				return Features.LongVacation;
			}
		},
		new QuestionObj
		{
			Id = 2,
			DisplayValue = "Чи бажаєте активну відпустку (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.Active : Features.Lazy;
			}
		},
		new QuestionObj
		{
			Id = 3,
			DisplayValue = "Чи бажаєте ЕКСТРИМАЛЬНУ відпустку (y/n)?",
			RequiredFeatures = new List<Features> { Features.Active },
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.Extreme : Features.NA;
			}
		},
		new QuestionObj
		{
			Id = 4,
			DisplayValue = "Море (1) чи гори (2)?",
			GetFeatureResult = (x) =>
			{
				return x == "1" ? Features.Sea : Features.Mountain;
			}
		},
		new QuestionObj
		{
			Id = 5,
			DisplayValue = "Чи добре ви переносите політ на літаку (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.AeroOk : Features.Aerophobia;
			}
		},
		new QuestionObj
		{
			Id = 6,
			DisplayValue = "Чи є у вас морська хвороба (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.SeaSickness : Features.ShipOk;
			}
		},
		new QuestionObj
		{
			Id = 7,
			DisplayValue = "Чи подобаються вам острови (y/n)?",
			RequiredFeatures = new List<Features> { Features.AeroOk },
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.Island : Features.Continental;
			}
		},
		new QuestionObj
		{
			Id = 8,
			DisplayValue = "Як ви ставитесь до круїзів (y/n)?",
			RequiredFeatures = new List<Features> { Features.ShipOk },
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.ShipCrouise : Features.NA;
			}
		},
		new QuestionObj
		{
			Id = 9,
			DisplayValue = "Чи хочете відвідати нові міста (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.EuropeCity : Features.NA;
			}
		},
		new QuestionObj
		{
			Id = 10,
			DisplayValue = "Який у вас бюджет на відпустку?",
			GetFeatureResult = (x) =>
			{
				var val = int.Parse(x);
				if (val < 500) return Features.CheapPrice;
				if(val >= 500 && val < 1500) return Features.MediumPrice;
				return Features.HighPrice;
			}
		},
		new QuestionObj
		{
			Id = 11,
			DisplayValue = "Чи важливий вам комфорт (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.Camping : Features.Comfortable;
			}
		},
		new QuestionObj
		{
			Id = 12,
			DisplayValue = "Чи є можливість прибути у іншу країну (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.Abroad : Features.InsideCountry;
			}
		},
		new QuestionObj
		{
			Id = 13,
			DisplayValue = "Чи важлива вам безперка (y/n)?",
			GetFeatureResult = (x) =>
			{
				return CheckYesNoText(x) ? Features.Safe : Features.Dangerous;
			}
		},

	};

	public static bool CheckYesNoText(string text) => text.ToLower() == "yes" || text.ToLower() == "y";
}