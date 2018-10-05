using CompetentResponse;

namespace Sample.Logics.User.Update
{
    public class UserUpdateResponse : Response<UserUpdateError>
    {
        public UserUpdateResponse(UserUpdateError error, object item = null)
            : base(new ErrorContainer<UserUpdateError>(error, item))
        {
        }

        public UserUpdateResponse()
        {
        }
    }
}
