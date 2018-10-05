using CompetentResponse;

namespace Sample.Logics.User.Delete
{
    public class UserDeleteResponse : Response<UserDeleteError>
    {
        public UserDeleteResponse(UserDeleteError error)
            : base(error)
        {
        }

        public UserDeleteResponse()
        {
        }
    }
}
