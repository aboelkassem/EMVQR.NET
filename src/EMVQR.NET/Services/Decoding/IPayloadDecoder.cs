using EMVQR.Utils;
using System.Collections.Generic;

namespace EMVQR.Services.Decoding
{
    internal interface IPayloadDecoder<T>
    {
        T BuildPayload(ICollection<Tlv> tlvs);

        ICollection<Tlv> DecodeQR(string qrData);

        string ValidateCrc(string qrData);
    }
}
