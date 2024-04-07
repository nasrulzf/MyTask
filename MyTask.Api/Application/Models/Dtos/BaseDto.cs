namespace MyTask.Api.Application.Models.Dtos;

public abstract class BaseDto 
{
    public bool IsSuccess {get;set;}
    public List<string>? Messages {get;set;}
}