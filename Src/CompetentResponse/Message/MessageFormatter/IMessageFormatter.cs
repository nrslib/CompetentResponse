using System.Collections.Generic;

namespace CompetentResponse.Message.MessageFormatter {
  public interface IMessageFormatter {
    string Format<TErrorCode>(IEnumerable<ErrorContainer<TErrorCode>> errors, ErrorMessageProvider<TErrorCode> provider);
  }
}