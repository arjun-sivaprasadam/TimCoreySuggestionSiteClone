namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Suggestion { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
    public CategoryModel Category { get; set; }
    public UserModel Author { get; set; }
    public HashSet<string> UserVotes { get; set; } = new();
    public StatusModel SuggestionStatus { get; set; }
    public string OwnerNotes { get; set; }
    public bool IsApprovedForRelease { get; set; } = false;
    public bool IsArchived { get; set; } = false;
    public bool IsRejected { get; set; } = false;
}