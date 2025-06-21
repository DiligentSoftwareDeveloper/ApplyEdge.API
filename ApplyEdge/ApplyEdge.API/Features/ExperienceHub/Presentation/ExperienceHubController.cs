using Amazon.DynamoDBv2.DataModel;
using ApplyEdge.API.Features.ExperienceHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApplyEdge.API.Features.ExperienceHub.Presentation;

public class ExperienceHubController : Controller
{
    private readonly IDynamoDBContext _dynamoDbContext;
    public ExperienceHubController(IDynamoDBContext dynamoDbContext)
    {
        _dynamoDbContext = dynamoDbContext;
    }

    [HttpGet]
    [Route("api/v1/experience")]
    public async Task<IActionResult> AddExperience()
    {
        Console.WriteLine("Test");
        
        await _dynamoDbContext.SaveAsync(new Experience()
        {
            Id = Guid.NewGuid().ToString(),
            Type = "Job",
            Name = "Test1"
        });
        return Ok(new
        {
            Response = "Test"
        });
    }
    
    [HttpPost]
    [Route("api/v1/achievement/category")]
    public async Task<IActionResult> AddAchievementCategory()
    {
        return Ok(new
        {
            Response = "Test"
        });
    }
    
    [HttpPost]
    [Route("api/v1/achievement")]
    public async Task<IActionResult> AddAchievement()
    {
        return Ok(new
        {
            Response = "Test"
        });
    }
}