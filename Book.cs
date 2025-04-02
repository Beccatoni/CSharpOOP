namespace oopiInCsharp;

public class Book
{
    public string Author
    { get; private set; }
    
    public string Title
    { get; private set; }

    public Book(string author = "Unknown", string title = "Untitled")
    {
        Author = author;
        Title = title;
    }

    public virtual string Stringify()
    {
        return "This is a Book object!";
    }
}

class Novel : Book, IFlippable
{
    public int CurrentPage { get;  set; }

    private List<string> chapterList;

    public Novel(List<string> chapters, int page = 0) : base()
    {
        CurrentPage = page;
        chapterList = chapters;
    }

    public Novel(List<string> chapters, int page = 0, string author = "Unknown", string title = "Untitled") : base(author, title)
    {
        CurrentPage = page;
        chapterList = new List<string>();
    }

    public Novel(int page = 0, string author = "Unknown", string title = "Untitled") : base(author, title)
    {
        CurrentPage = page;
        chapterList = new List<string>();
    }
    public void Flip()
    {
        CurrentPage++;
    }

    public void LogChapters()
    {
        foreach (string chapter in chapterList)
        {
            Console.WriteLine(chapter);
        }
    }

    public override string Stringify()
    {
        return "This is a Novel object!";
    }
}

class Encyclopedia : Book, IFlippable
{
    public int CurrentPage { get;  set; }

    public Encyclopedia(int page = 0, string author="Unknown", string title = "Untitled") : base(author, title)
    {
        CurrentPage = page;
    }

    public void Flip()
    {
        CurrentPage++;
    }

    public string Define()
    {
        return "Encyclopedia: a work that contains information on all branches of knowledge or comprehensively comprehensively covers a particular branch of knowledge, usually in articles arranged alphabetically by subject; often comes in multiple volumes.";
    }

    public override string Stringify()
    {
        return "This is an Encyclopedia object!";
    }
}