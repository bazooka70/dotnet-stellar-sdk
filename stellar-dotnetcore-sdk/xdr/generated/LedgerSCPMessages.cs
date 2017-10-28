// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  struct LedgerSCPMessages
//  {
//      uint32 ledgerSeq;
//      SCPEnvelope messages<>;
//  };

//  ===========================================================================
public class LedgerSCPMessages  {
  public LedgerSCPMessages () {}
  public Uint32 LedgerSeq {get; set;}
  public SCPEnvelope[] Messages {get; set;}

  public static void Encode(IByteWriter stream, LedgerSCPMessages encodedLedgerSCPMessages) {
    Uint32.Encode(stream, encodedLedgerSCPMessages.LedgerSeq);
    int messagessize = encodedLedgerSCPMessages.Messages.Length;
    XdrEncoding.EncodeInt32(messagessize, stream);
    for (int i = 0; i < messagessize; i++) {
      SCPEnvelope.Encode(stream, encodedLedgerSCPMessages.Messages[i]);
    }
  }
  public static LedgerSCPMessages Decode(IByteReader stream) {
    LedgerSCPMessages decodedLedgerSCPMessages = new LedgerSCPMessages();
    decodedLedgerSCPMessages.LedgerSeq = Uint32.Decode(stream);
    int messagessize = XdrEncoding.DecodeInt32(stream);
    decodedLedgerSCPMessages.Messages = new SCPEnvelope[messagessize];
    for (int i = 0; i < messagessize; i++) {
      decodedLedgerSCPMessages.Messages[i] = SCPEnvelope.Decode(stream);
    }
    return decodedLedgerSCPMessages;
  }
}
}