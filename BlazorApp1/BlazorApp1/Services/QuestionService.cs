using BlazorApp1.Models;

namespace BlazorApp1.Services;

public class QuestionService
{
	public List<Question> GetAllQuestions()
	{
		return new List<Question>(new[] {
			new Question
			{
				QuestionId = "1",
				DisplayValue = "Вам більше до вподоби автомобілі...",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Меншого розміру",
						IsFinal = false,
						QuestionIdRef = "2",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "Середні",
						IsFinal = false,
						QuestionIdRef = "6",
					},
					new Answer
					{
						AnswerId = "3",
						DisplayValue = "Більшого розміру",
						IsFinal = false,
						QuestionIdRef = "7",
					},
				}
			},

			new Question
			{
				QuestionId = "2",
				DisplayValue = "Чи важливий високий кліренс?",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Так",
						IsFinal = false,
						QuestionIdRef = "4",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "Ні",
						IsFinal = false,
						QuestionIdRef = "3",
					},
				}
			},

			new Question
			{
				QuestionId = "3",
				DisplayValue = "Тип двигуна?",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Електро",
						IsFinal = true,
						ResultIdRef = "1",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "Бензин",
						IsFinal = true,
						ResultIdRef = "2",
					},
				}
			},

			new Question
			{
				QuestionId = "4",
				DisplayValue = "Чи потрібна підвищена проходимість?",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Так",
						IsFinal = false,
						QuestionIdRef = "5",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "Ні",
						IsFinal = false,
						QuestionIdRef = "3",
					},
				}
			},

			new Question
			{
				QuestionId = "5",
				DisplayValue = "Авто на велику сім'ю?",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Так",
						IsFinal = false,
						QuestionIdRef = "7",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "Ні",
						IsFinal = true,
						ResultIdRef = "3"
					},
				}
			},

			new Question
			{
				QuestionId = "6",
				DisplayValue = "Для міста чи за місто?",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Для міста",
						IsFinal = false,
						QuestionIdRef = "4",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "За місто",
						IsFinal = false,
						QuestionIdRef = "7",
					},
				}
			},

			new Question
			{
				QuestionId = "7",
				DisplayValue = "Клас автомобіля?",
				Answers = new List<Answer> {
					new Answer
					{
						AnswerId = "1",
						DisplayValue = "Преміум",
						IsFinal = true,
						ResultIdRef = "4",
					},
					new Answer
					{
						AnswerId = "2",
						DisplayValue = "Середній",
						IsFinal = true,
						ResultIdRef = "6",
					},
					new Answer
					{
						AnswerId = "3",
						DisplayValue = "Бюджет",
						IsFinal = true,
						ResultIdRef = "5",
					},
				}
			},
		});
	}

	public List<Result> GetAllResults()
	{
		return new List<Result>
		{
			new Result
			{
				ResultId = "1",
				DisplayValue = "Tesla Model 3",
				PictureUrl = "https://i.infocar.ua/i/12/5590/1400x936.jpg"
			},
			new Result
			{
				ResultId = "2",
				DisplayValue = "Hyundai Elantra",
				PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/8/82/2022_Hyundai_Elantra_N_in_Fiery_Red%2C_Front_Left%2C_04-18-2022.jpg"
			},
			new Result
			{
				ResultId = "3",
				DisplayValue = "Peugeot 2008",
				PictureUrl = "https://i.infocar.ua/i/12/6030/1400x936.jpg"
			},
			new Result
			{
				ResultId = "4",
				DisplayValue = "Audi Q8",
				PictureUrl = "https://i.infocar.ua/i/6/138963/650x.jpg"
			},
			new Result
			{
				ResultId = "5",
				DisplayValue = "Renault Duster",
				PictureUrl = "https://storage.m.renault.ua/source/15/VujDMYRWTaGdQjdwAhH2lDoMaiO4COh3.jpg"
			},
			new Result
			{
				ResultId = "6",
				DisplayValue = "Skoda Kodiaq",
				PictureUrl = "https://www.ixbt.com/img/n1/news/2021/8/3/skoda-kodiaq-8_large.jpg"
			},
		};
	}
}
