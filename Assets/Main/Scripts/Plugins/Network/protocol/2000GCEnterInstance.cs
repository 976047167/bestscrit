// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 2000_GCEnterInstance.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 2000_GCEnterInstance.proto</summary>
  public static partial class GCEnterInstanceReflection {

    #region Descriptor
    /// <summary>File descriptor for 2000_GCEnterInstance.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCEnterInstanceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChoyMDAwX0dDRW50ZXJJbnN0YW5jZS5wcm90bxoVUEJNYXBQbGF5ZXJEYXRh",
            "LnByb3RvImAKD0dDRW50ZXJJbnN0YW5jZRIOCgZyZXN1bHQYASABKAUSEgoK",
            "aW5zdGFuY2VJZBgCIAEoBRIpCg9tYXBfcGxheWVyX2RhdGEYAyABKAsyEC5Q",
            "Qk1hcFBsYXllckRhdGFCSwodY29tLndoYWxlaXNsYW5kLmdhbWUucHJvdG9j",
            "b2xCF0dDRW50ZXJJbnN0YW5jZVByb3RvY29sqgIQQmlnSGVhZC5wcm90b2Nv",
            "bGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::BigHead.protocol.PBMapPlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.GCEnterInstance), global::BigHead.protocol.GCEnterInstance.Parser, new[]{ "Result", "InstanceId", "MapPlayerData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Enter Instance response
  /// </summary>
  public sealed partial class GCEnterInstance : pb::IMessage<GCEnterInstance> {
    private static readonly pb::MessageParser<GCEnterInstance> _parser = new pb::MessageParser<GCEnterInstance>(() => new GCEnterInstance());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GCEnterInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.GCEnterInstanceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCEnterInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCEnterInstance(GCEnterInstance other) : this() {
      result_ = other.result_;
      instanceId_ = other.instanceId_;
      MapPlayerData = other.mapPlayerData_ != null ? other.MapPlayerData.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCEnterInstance Clone() {
      return new GCEnterInstance(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private int result_;
    /// <summary>
    ///0Success,1failed
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "instanceId" field.</summary>
    public const int InstanceIdFieldNumber = 2;
    private int instanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int InstanceId {
      get { return instanceId_; }
      set {
        instanceId_ = value;
      }
    }

    /// <summary>Field number for the "map_player_data" field.</summary>
    public const int MapPlayerDataFieldNumber = 3;
    private global::BigHead.protocol.PBMapPlayerData mapPlayerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BigHead.protocol.PBMapPlayerData MapPlayerData {
      get { return mapPlayerData_; }
      set {
        mapPlayerData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GCEnterInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GCEnterInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (InstanceId != other.InstanceId) return false;
      if (!object.Equals(MapPlayerData, other.MapPlayerData)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (InstanceId != 0) hash ^= InstanceId.GetHashCode();
      if (mapPlayerData_ != null) hash ^= MapPlayerData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Result);
      }
      if (InstanceId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(InstanceId);
      }
      if (mapPlayerData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MapPlayerData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (InstanceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(InstanceId);
      }
      if (mapPlayerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapPlayerData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GCEnterInstance other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.InstanceId != 0) {
        InstanceId = other.InstanceId;
      }
      if (other.mapPlayerData_ != null) {
        if (mapPlayerData_ == null) {
          mapPlayerData_ = new global::BigHead.protocol.PBMapPlayerData();
        }
        MapPlayerData.MergeFrom(other.MapPlayerData);
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
            Result = input.ReadInt32();
            break;
          }
          case 16: {
            InstanceId = input.ReadInt32();
            break;
          }
          case 26: {
            if (mapPlayerData_ == null) {
              mapPlayerData_ = new global::BigHead.protocol.PBMapPlayerData();
            }
            input.ReadMessage(mapPlayerData_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
