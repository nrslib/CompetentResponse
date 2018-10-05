using System.Collections.Generic;
using System.Linq;

namespace CompetentResponse {
  public abstract class Response<TErrorCode> {
    protected Response(TErrorCode error)
      : this(new[] {error}) {
    }

    protected Response(IEnumerable<TErrorCode> errors)
      : this(errors.Select(x => new ErrorContainer<TErrorCode>(x))) {
    }

    protected Response(ErrorContainer<TErrorCode> error)
      : this(new[] {error}) {
    }

    protected Response(IEnumerable<ErrorContainer<TErrorCode>> errors) {
      Errors = errors.ToArray();
    }

    protected Response() {
      Errors = new ErrorContainer<TErrorCode>[] { };
    }

    public ErrorContainer<TErrorCode>[] Errors { get; }

    public bool HasError() {
      return Errors.Any();
    }
  }
}