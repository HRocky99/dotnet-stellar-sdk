// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  enum SignerKeyType
//  {
//      SIGNER_KEY_TYPE_ED25519 = KEY_TYPE_ED25519,
//      SIGNER_KEY_TYPE_PRE_AUTH_TX = KEY_TYPE_PRE_AUTH_TX,
//      SIGNER_KEY_TYPE_HASH_X = KEY_TYPE_HASH_X
//  };

//  ===========================================================================
public class SignerKeyType  {
  public enum SignerKeyTypeEnum {
  SIGNER_KEY_TYPE_ED25519 = 0,
  SIGNER_KEY_TYPE_PRE_AUTH_TX = 1,
  SIGNER_KEY_TYPE_HASH_X = 2,
  }
  public SignerKeyTypeEnum InnerValue {get; set;} = default(SignerKeyTypeEnum);

  public static SignerKeyType Create(SignerKeyTypeEnum v)
  {
    return new SignerKeyType {
      InnerValue = v
    };
  }

  public static SignerKeyType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(SignerKeyTypeEnum.SIGNER_KEY_TYPE_ED25519);
      case 1: return Create(SignerKeyTypeEnum.SIGNER_KEY_TYPE_PRE_AUTH_TX);
      case 2: return Create(SignerKeyTypeEnum.SIGNER_KEY_TYPE_HASH_X);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(IByteWriter stream, SignerKeyType value) {
    XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
  }
}
}
