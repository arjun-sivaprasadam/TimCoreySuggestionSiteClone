namespace SuggestionAppLibrary.Models;
public class BaseUserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string DisplayName { get; set; }

    public BaseUserModel() { }

    public BaseUserModel(UserModel user)
    {
        Id = user.Id;
        DisplayName = user.DisplayName;
    }
}
