using Amazon.DynamoDBv2.DataModel;

namespace ApplyEdge.API.Features.ExperienceHub.Domain.Entities;

[DynamoDBTable("Experiences")]
public class Experience
{
    [DynamoDBHashKey]
    public string Id { get; set; }

    public string Type { get; set; }
    public string Name { get; set; }
}