using System.Collections.Generic;
using System.Linq;
using CompetentResponse;
using CompetentResponse.Message;
using CompetentResponse.Message.MessageFormatter;

namespace Sample.MessageFormatter {
  public class JoinByWebBrTagMessageFormatter : IMessageFormatter {
    public string Format<TErrorCode>(IEnumerable<ErrorContainer<TErrorCode>> errors, ErrorMessageProvider<TErrorCode> provider) {
      return string.Join(
        "<br>",
        errors.Select(e => {
          var errorMessage = provider.ErrorMessage(e.ErrorCode);
          errorMessage = string.Format(errorMessage, e.Item);
          return errorMessage;
        })
      );
    }
  }
}
