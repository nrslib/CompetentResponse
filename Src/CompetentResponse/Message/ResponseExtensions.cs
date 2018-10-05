using System;
using System.Collections.Concurrent;
using CompetentResponse.Message.MessageFormatter;

namespace CompetentResponse.Message {
  public static class ResponseExtensions {
    private static ConcurrentDictionary<Type, IErrorMessageProvider> providers = new ConcurrentDictionary<Type, IErrorMessageProvider>();

    public static string ToErrorMessage<TErrorCode>(this Response<TErrorCode> response, IMessageFormatter aFormatter = null) {
      if (!response.HasError()) {
        return "";
      }

      var formatter = aFormatter ?? new NewLineMessageFormatter();
      var provider = getProvider<TErrorCode>();
      var message = formatter.Format(response.Errors, provider);

      return message;
    }

    private static ErrorMessageProvider<TErrorCode> getProvider<TErrorCode>() {
      var type = typeof(TErrorCode);
      var provider = providers.GetOrAdd(type, _ => new ErrorMessageProvider<TErrorCode>());
      return (ErrorMessageProvider<TErrorCode>)provider;
    }
  }
}
