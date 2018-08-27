// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 3000_CGEnterBattle.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 3000_CGEnterBattle.proto</summary>
  public static partial class CGEnterBattleReflection {

    #region Descriptor
    /// <summary>File descriptor for 3000_CGEnterBattle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CGEnterBattleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChgzMDAwX0NHRW50ZXJCYXR0bGUucHJvdG8iIgoNQ0dFbnRlckJhdHRsZRIR",
            "Cgltb25zdGVySWQYASABKAVCSQodY29tLndoYWxlaXNsYW5kLmdhbWUucHJv",
            "dG9jb2xCFUNHRW50ZXJCYXR0bGVQcm90b2NvbKoCEEJpZ0hlYWQucHJvdG9j",
            "b2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.CGEnterBattle), global::BigHead.protocol.CGEnterBattle.Parser, new[]{ "MonsterId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 进入战斗请求
  /// </summary>
  public sealed partial class CGEnterBattle : pb::IMessage<CGEnterBattle> {
    private static readonly pb::MessageParser<CGEnterBattle> _parser = new pb::MessageParser<CGEnterBattle>(() => new CGEnterBattle());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CGEnterBattle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.CGEnterBattleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGEnterBattle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGEnterBattle(CGEnterBattle other) : this() {
      monsterId_ = other.monsterId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CGEnterBattle Clone() {
      return new CGEnterBattle(this);
    }

    /// <summary>Field number for the "monsterId" field.</summary>
    public const int MonsterIdFieldNumber = 1;
    private int monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CGEnterBattle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CGEnterBattle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonsterId != other.MonsterId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MonsterId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MonsterId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MonsterId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CGEnterBattle other) {
      if (other == null) {
        return;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
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
            MonsterId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code