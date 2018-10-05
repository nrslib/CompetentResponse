namespace Sample.Logics.User.Update {
  public class UserUpdateInteractor {
    public UserUpdateResponse Handle(UserUpdateRequest request) {
      if (request.UserName.Contains("@")) {
        return new UserUpdateResponse(UserUpdateError.InvalidUserName, request.UserName);
      }

      return new UserUpdateResponse();
    }
  }
}
