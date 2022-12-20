namespace BlazorApp1.Models;

public class Question : BaseDisplayableObj
{
	public string QuestionId { get; set; }
	public List<Answer> Answers { get; set; } = new List<Answer>();
}

public class Answer : BaseDisplayableObj
{
	public string AnswerId { get; set; }
	public bool IsFinal { get; set; }
	public string QuestionIdRef { get; set; }
	public string ResultIdRef { get; set; }
}

public class Result : BaseDisplayableObj
{
	public string ResultId { get; set; }
	public string PictureUrl { get; set; }
}

public abstract class BaseDisplayableObj
{
	public string DisplayValue { get; set; }
}

public class QuestionWithAnswer
{
	public int Pos { get; set; }
	public string QuestionId { get; set; }
	public string AnswerId { get; set; }
}