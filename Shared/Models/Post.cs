namespace Shared.Models;

public class Post
{
    public String Title { get; set; }
    public String textBody { get; set; }
    public User Author { get; set; }


    public Post(string title, User author)
    {
        Title = title;
        Author = author;
    }
    
    
}