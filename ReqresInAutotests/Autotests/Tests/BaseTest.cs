using NUnit.Framework;
using RestSharp;

namespace ReqresInAutotests.Autotests.Tests;

[TestFixture]
public class BaseTest
{

    protected readonly RestClient Client;

    public BaseTest()
    {
        Client = new RestClient("https://reqres.in/");
    }
}
