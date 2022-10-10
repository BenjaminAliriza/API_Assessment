global using NUnit.Framework;
namespace APIAssessment;

public class APITests
{
    APICalls ac;
    String url = "https://jsonplaceholder.typicode.com/posts/";

    [SetUp]
    public void Setup()
    {
        this.ac = new APICalls();
    }

    [Test]
    public void Test_GetAllPostsResources()
    {
        Assert.AreEqual("OK", ac.ExecuteGet(url));
    }

    [Test]
    public void Test_GetAllPostsResourcesWithID()
    {
        Assert.AreEqual("OK", ac.ExecuteGet(url + "11"));
    }

    [Test]
    public void Test_PostNewPostsResource()
    {
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("title", "foo");
        headers.Add("body", "bar");
        headers.Add("userId", "1");

        Assert.AreEqual("Created", ac.ExecutePost(url, headers));
    }

    [Test]
    public void Test_DeletePostsResourceWithId1()
    {
        Assert.AreEqual("OK", ac.ExecuteDelete(url + "1"));
    }
}