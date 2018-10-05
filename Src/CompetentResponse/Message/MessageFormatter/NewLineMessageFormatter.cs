using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetentResponse.Message.MessageFormatter
{
  public class NewLineMessageFormatter : IMessageFormatter
  {
    public string Format<TErrorCode>(IEnumerable<ErrorContainer<TErrorCode>> errors, ErrorMessageProvider<TErrorCode> provider)
    {
      return string.Join(
        Environment.NewLine,
        errors.Select(e => {
          var errorMessage = provider.ErrorMessage(e.ErrorCode);
          errorMessage = string.Format(errorMessage, e.Item);
          return errorMessage;
        })
      );
    }
  }
}
