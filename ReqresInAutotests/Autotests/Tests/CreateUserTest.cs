using NUnit.Framework;
using ReqresInAutotests.Autotests.DataCreator;
using ReqresInAutotests.Autotests.Model;
using RestSharp;
using RestSharp.Serializers;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReqresInAutotests.Autotests.Tests;

[TestFixture]
public class CreateUserTest : BaseTest
{
    [Test]
    public async Task createUserTest()
    {

        var UserData = new UserData().CreateUserData();

        var createUser = new RestRequest("/api/users", Method.Post)
            .AddHeader("Content-Type", ContentType.Json)
            .AddJsonBody(UserData);
        var response = await Client.ExecutePostAsync(createUser);
        var UserResponseData = JsonSerializer.Deserialize<CreateUserResponse>(response.Content);

        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        Assert.AreEqual(UserData.Name, UserResponseData.Name);
        Assert.AreEqual(UserData.Job, UserResponseData.Job);
        Assert.NotNull(UserResponseData.Id);
        Assert.NotNull(UserResponseData.CreatedAt);
    }
}
