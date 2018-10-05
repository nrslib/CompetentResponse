using System.Collections.Generic;
using System.Linq;

namespace CompetentResponse.Message {
  public interface IErrorMessageProvider {
  }

  public class ErrorMessageProvider<TErrorCode> : IErrorMessageProvider {
    private readonly Dictionary<TErrorCode, ErrorMessageAttribute> cache;

    public ErrorMessageProvider() {
      var type = typeof(TErrorCode);
      var lookup = type.GetFields()
        .Where(x => x.FieldType == type)
        .SelectMany(x => x.GetCustomAttributes(false), (x, attribute) => new {code = x.GetValue(null), attribute})
        .ToLookup(x => x.attribute.GetType());

      cache = lookup[typeof(ErrorMessageAttribute)].ToDictionary(x => (TErrorCode) x.code, x => (ErrorMessageAttribute) x.attribute);
    }

    public string ErrorMessage(TErrorCode key) {
      if (cache.TryGetValue(key, out var errorMessageAttribute)) {
        return errorMessageAttribute.Message;
      } else {
        return "";
      }
    }
  }
}