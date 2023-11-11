namespace SuggestionAppLibrary.Models;

public class BaseSuggestionModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Suggestion { get; set; }

    public BaseSuggestionModel() { }

    public BaseSuggestionModel(SuggestionModel suggestion)
    {
        Id = suggestion.Id;
        Suggestion = suggestion.Suggestion;
    }
}
