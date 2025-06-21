using Microsoft.AspNetCore.Mvc;

namespace ApplyEdge.API.Features.ExperienceHub.Presentation;

public class ExperienceHubController : Controller
{

    [HttpPost]
    [Route("api/v1/experience")]
    public async Task<IActionResult> AddExperience()
    {
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