namespace Sample.Logics.User.Update {
  public class UserUpdateRequest {
    public UserUpdateRequest(string id, string userName) {
      Id = id;
      UserName = userName;
    }


    public string Id { get; }
    public string UserName { get; }
  }
}