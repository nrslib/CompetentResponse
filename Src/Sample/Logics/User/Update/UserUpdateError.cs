using CompetentResponse.Message;

namespace Sample.Logics.User.Update {
  public enum UserUpdateError {
    [ErrorMessage("ユーザが存在しません")]
    UserNotFound,

    [ErrorMessage("すでに存在しているユーザ名です")]
    Duplicated,

    [ErrorMessage("'{0}'というユーザ名には利用できない文字が利用されています")]
    InvalidUserName,
  }
}