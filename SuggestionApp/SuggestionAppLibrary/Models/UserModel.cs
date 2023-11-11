namespace SuggestionAppLibrary.Models;

public class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ObjectIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string Email { get; set; }
    public List<BaseSuggestionModel> Suggestions { get; set; } = new();
    public List<BaseSuggestionModel> VotedSuggestions { get; set; } = new();
}