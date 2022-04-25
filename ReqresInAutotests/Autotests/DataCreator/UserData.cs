using ReqresInAutotests.Autotests.Model;

namespace ReqresInAutotests.Autotests.DataCreator;

public class UserData
{
    public UserRequest CreateUserData()
    {
        var userData = new UserRequest
        {
            Name = Faker.NameFaker.FirstName(),
            Job = Faker.NameFaker.LastName()
        };

        return userData;
    }
}
