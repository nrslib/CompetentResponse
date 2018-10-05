using System;

namespace CompetentResponse.Message {
  [AttributeUsage(AttributeTargets.Field)]
  public class ErrorMessageAttribute : Attribute {
    public ErrorMessageAttribute(string message) {
      Message = message;
    }

    public string Message { get; }
  }
}
