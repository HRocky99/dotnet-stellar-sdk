// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  union AllowTrustResult switch (AllowTrustResultCode code)
//  {
//  case ALLOW_TRUST_SUCCESS:
//      void;
//  default:
//      void;
//  };

//  ===========================================================================
public class AllowTrustResult  {
  public AllowTrustResult () {}

  AllowTrustResultCode Discriminant { get; set; } = new AllowTrustResultCode();

  public static void Encode(IByteWriter stream, AllowTrustResult encodedAllowTrustResult) {
  XdrEncoding.EncodeInt32((int)encodedAllowTrustResult.Discriminant.InnerValue, stream);
  switch (encodedAllowTrustResult.Discriminant.InnerValue) {
  case AllowTrustResultCode.AllowTrustResultCodeEnum.ALLOW_TRUST_SUCCESS:
  break;
  default:
  break;
  }
  }
  public static AllowTrustResult Decode(IByteReader stream) {
  AllowTrustResult decodedAllowTrustResult = new AllowTrustResult();
  AllowTrustResultCode discriminant = AllowTrustResultCode.Decode(stream);
  decodedAllowTrustResult.Discriminant = discriminant;
  switch (decodedAllowTrustResult.Discriminant.InnerValue) {
  case AllowTrustResultCode.AllowTrustResultCodeEnum.ALLOW_TRUST_SUCCESS:
  break;
  default:
  break;
  }
    return decodedAllowTrustResult;
  }
}
}
