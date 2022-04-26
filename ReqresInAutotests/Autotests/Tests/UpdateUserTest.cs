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
public class UpdateUserTest : BaseTest
{
    [Test]
    public async Task UpdateUserByIdTest()
    {
        int id = 2;
        var userData = new UserData().CreateUserData();

        var updateUser = new RestRequest("/api/users/" + id, Method.Put)
            .AddHeader("Content-Type", ContentType.Json)
            .AddJsonBody(userData);
        var response = await Client.PutAsync(createUser);
        var UserResponseData = JsonSerializer.Deserialize<UpdateUserResponse>(response.Content);

        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        Assert.AreEqual(userData.Name, UserResponseData.Name);
        Assert.AreEqual(userData.Job, UserResponseData.Job);
        Assert.NotNull(UserResponseData.UpdatedAt);
    }
}
