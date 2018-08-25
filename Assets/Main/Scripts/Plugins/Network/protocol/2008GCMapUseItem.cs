// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 2008_GCMapUseItem.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 2008_GCMapUseItem.proto</summary>
  public static partial class GCMapUseItemReflection {

    #region Descriptor
    /// <summary>File descriptor for 2008_GCMapUseItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCMapUseItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChcyMDA4X0dDTWFwVXNlSXRlbS5wcm90byIxCgxHQ01hcFVzZUl0ZW0SEQoJ",
            "cGxheWVyX2lkGAEgASgEEg4KBnJlc3VsdBgCIAEoBUJICh1jb20ud2hhbGVp",
            "c2xhbmQuZ2FtZS5wcm90b2NvbEIUR0NNYXBVc2VJdGVtUHJvdG9jb2yqAhBC",
            "aWdIZWFkLnByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.GCMapUseItem), global::BigHead.protocol.GCMapUseItem.Parser, new[]{ "PlayerId", "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 在地图上使用消耗品
  /// </summary>
  public sealed partial class GCMapUseItem : pb::IMessage<GCMapUseItem> {
    private static readonly pb::MessageParser<GCMapUseItem> _parser = new pb::MessageParser<GCMapUseItem>(() => new GCMapUseItem());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GCMapUseItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.GCMapUseItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCMapUseItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCMapUseItem(GCMapUseItem other) : this() {
      playerId_ = other.playerId_;
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCMapUseItem Clone() {
      return new GCMapUseItem(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private ulong playerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private int result_;
    /// <summary>
    ///0success
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GCMapUseItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GCMapUseItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0UL) hash ^= PlayerId.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PlayerId);
      }
      if (Result != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerId);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GCMapUseItem other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0UL) {
        PlayerId = other.PlayerId;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerId = input.ReadUInt64();
            break;
          }
          case 16: {
            Result = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
