using NUnit.Framework;
using RestSharp;
using RestSharp.Serializers;
using System.Net;
using System.Threading.Tasks;

namespace ReqresInAutotests.Autotests.Tests;

[TestFixture]
public class DeleteUserTest : BaseTest
{
    [Test]
    public async Task DeleteUserByIdTest()
    {
        int id = 2;

        var deleteUser = new RestRequest("/api/users/" + id, Method.Delete);
        var response = await Client.DeleteAsync(deleteUser);

        Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
    }
}
