namespace CompetentResponse
{
    public class ErrorContainer<TErrorCode>
    {
        public ErrorContainer(TErrorCode code, object item = null)
        {
            ErrorCode = code;
            Item = item;
        }

        public TErrorCode ErrorCode { get; }
        public object Item { get; }
    }
}
