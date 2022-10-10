using RestSharp;

namespace APIAssessment;

public class APICalls
{
    public String ExecutePost(string url, Dictionary<string, string> headers)
    {
        var client = new RestClient(url);
        client.Timeout = -1;
        var request = new RestRequest(Method.POST);
        request.AlwaysMultipartFormData = true;

        foreach(var header in headers){
            request.AddParameter(header.Key, header.Value);
        }
       
       
        IRestResponse response = client.Execute(request);
        return response.StatusCode.ToString();
    }


    public String ExecuteGet(String url)
    {
        var client = new RestClient(url);
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response.StatusCode.ToString();
    }

    public String ExecuteDelete(String url)
    {
        var client = new RestClient(url);
        client.Timeout = -1;
        var request = new RestRequest(Method.DELETE);
        request.AlwaysMultipartFormData = true;
        IRestResponse response = client.Execute(request);
        return response.StatusCode.ToString();
    }

}