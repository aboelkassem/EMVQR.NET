namespace EMVQR.Services.Encoding
{
    public interface IPayloadEncoding<T>
    {
        string GeneratePayload(T payload);
    }
}
