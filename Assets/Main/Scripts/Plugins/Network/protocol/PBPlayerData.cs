// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PBPlayerData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from PBPlayerData.proto</summary>
  public static partial class PBPlayerDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PBPlayerData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PBPlayerDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQQlBsYXllckRhdGEucHJvdG8i9wEKDFBCUGxheWVyRGF0YRIRCglwbGF5",
            "ZXJfaWQYASABKAQSDAoEbmFtZRgCIAEoCRIUCgxjaGFyYWN0ZXJfaWQYAyAB",
            "KAUSDQoFbGV2ZWwYBCABKAUSCwoDZXhwGAUgASgFEgoKAmhwGAYgASgFEg4K",
            "Bm1heF9ocBgHIAEoBRIKCgJtcBgIIAEoBRIOCgZtYXhfbXAYCSABKAUSDAoE",
            "Zm9vZBgKIAEoBRIMCgRjb2luGAsgASgFEhEKCWhlYWRfaWNvbhgMIAEoBRIU",
            "CgxtYXBfc2tpbGxfaWQYDSABKAUSFwoPYmF0dGxlX3NraWxsX2lkGA4gASgF",
            "QiQKD2NvbS5jc2YuYmlnaGVhZKoCEEJpZ0hlYWQucHJvdG9jb2xiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.PBPlayerData), global::BigHead.protocol.PBPlayerData.Parser, new[]{ "PlayerId", "Name", "CharacterId", "Level", "Exp", "Hp", "MaxHp", "Mp", "MaxMp", "Food", "Coin", "HeadIcon", "MapSkillId", "BattleSkillId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Game Player's Data
  /// </summary>
  public sealed partial class PBPlayerData : pb::IMessage<PBPlayerData> {
    private static readonly pb::MessageParser<PBPlayerData> _parser = new pb::MessageParser<PBPlayerData>(() => new PBPlayerData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PBPlayerData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.PBPlayerDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBPlayerData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBPlayerData(PBPlayerData other) : this() {
      playerId_ = other.playerId_;
      name_ = other.name_;
      characterId_ = other.characterId_;
      level_ = other.level_;
      exp_ = other.exp_;
      hp_ = other.hp_;
      maxHp_ = other.maxHp_;
      mp_ = other.mp_;
      maxMp_ = other.maxMp_;
      food_ = other.food_;
      coin_ = other.coin_;
      headIcon_ = other.headIcon_;
      mapSkillId_ = other.mapSkillId_;
      battleSkillId_ = other.battleSkillId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBPlayerData Clone() {
      return new PBPlayerData(this);
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

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "character_id" field.</summary>
    public const int CharacterIdFieldNumber = 3;
    private int characterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CharacterId {
      get { return characterId_; }
      set {
        characterId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 4;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 5;
    private int exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 6;
    private int hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "max_hp" field.</summary>
    public const int MaxHpFieldNumber = 7;
    private int maxHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxHp {
      get { return maxHp_; }
      set {
        maxHp_ = value;
      }
    }

    /// <summary>Field number for the "mp" field.</summary>
    public const int MpFieldNumber = 8;
    private int mp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Mp {
      get { return mp_; }
      set {
        mp_ = value;
      }
    }

    /// <summary>Field number for the "max_mp" field.</summary>
    public const int MaxMpFieldNumber = 9;
    private int maxMp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxMp {
      get { return maxMp_; }
      set {
        maxMp_ = value;
      }
    }

    /// <summary>Field number for the "food" field.</summary>
    public const int FoodFieldNumber = 10;
    private int food_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Food {
      get { return food_; }
      set {
        food_ = value;
      }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 11;
    private int coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "head_icon" field.</summary>
    public const int HeadIconFieldNumber = 12;
    private int headIcon_;
    /// <summary>
    ///diamond is in account_data
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HeadIcon {
      get { return headIcon_; }
      set {
        headIcon_ = value;
      }
    }

    /// <summary>Field number for the "map_skill_id" field.</summary>
    public const int MapSkillIdFieldNumber = 13;
    private int mapSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MapSkillId {
      get { return mapSkillId_; }
      set {
        mapSkillId_ = value;
      }
    }

    /// <summary>Field number for the "battle_skill_id" field.</summary>
    public const int BattleSkillIdFieldNumber = 14;
    private int battleSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleSkillId {
      get { return battleSkillId_; }
      set {
        battleSkillId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PBPlayerData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PBPlayerData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Name != other.Name) return false;
      if (CharacterId != other.CharacterId) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Hp != other.Hp) return false;
      if (MaxHp != other.MaxHp) return false;
      if (Mp != other.Mp) return false;
      if (MaxMp != other.MaxMp) return false;
      if (Food != other.Food) return false;
      if (Coin != other.Coin) return false;
      if (HeadIcon != other.HeadIcon) return false;
      if (MapSkillId != other.MapSkillId) return false;
      if (BattleSkillId != other.BattleSkillId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0UL) hash ^= PlayerId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (CharacterId != 0) hash ^= CharacterId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (MaxHp != 0) hash ^= MaxHp.GetHashCode();
      if (Mp != 0) hash ^= Mp.GetHashCode();
      if (MaxMp != 0) hash ^= MaxMp.GetHashCode();
      if (Food != 0) hash ^= Food.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
      if (HeadIcon != 0) hash ^= HeadIcon.GetHashCode();
      if (MapSkillId != 0) hash ^= MapSkillId.GetHashCode();
      if (BattleSkillId != 0) hash ^= BattleSkillId.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (CharacterId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CharacterId);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Exp);
      }
      if (Hp != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Hp);
      }
      if (MaxHp != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MaxHp);
      }
      if (Mp != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Mp);
      }
      if (MaxMp != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(MaxMp);
      }
      if (Food != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Food);
      }
      if (Coin != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Coin);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(HeadIcon);
      }
      if (MapSkillId != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(MapSkillId);
      }
      if (BattleSkillId != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(BattleSkillId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (CharacterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CharacterId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Exp);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hp);
      }
      if (MaxHp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxHp);
      }
      if (Mp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mp);
      }
      if (MaxMp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxMp);
      }
      if (Food != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Food);
      }
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Coin);
      }
      if (HeadIcon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HeadIcon);
      }
      if (MapSkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MapSkillId);
      }
      if (BattleSkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleSkillId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PBPlayerData other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0UL) {
        PlayerId = other.PlayerId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.CharacterId != 0) {
        CharacterId = other.CharacterId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.MaxHp != 0) {
        MaxHp = other.MaxHp;
      }
      if (other.Mp != 0) {
        Mp = other.Mp;
      }
      if (other.MaxMp != 0) {
        MaxMp = other.MaxMp;
      }
      if (other.Food != 0) {
        Food = other.Food;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      if (other.HeadIcon != 0) {
        HeadIcon = other.HeadIcon;
      }
      if (other.MapSkillId != 0) {
        MapSkillId = other.MapSkillId;
      }
      if (other.BattleSkillId != 0) {
        BattleSkillId = other.BattleSkillId;
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
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            CharacterId = input.ReadInt32();
            break;
          }
          case 32: {
            Level = input.ReadInt32();
            break;
          }
          case 40: {
            Exp = input.ReadInt32();
            break;
          }
          case 48: {
            Hp = input.ReadInt32();
            break;
          }
          case 56: {
            MaxHp = input.ReadInt32();
            break;
          }
          case 64: {
            Mp = input.ReadInt32();
            break;
          }
          case 72: {
            MaxMp = input.ReadInt32();
            break;
          }
          case 80: {
            Food = input.ReadInt32();
            break;
          }
          case 88: {
            Coin = input.ReadInt32();
            break;
          }
          case 96: {
            HeadIcon = input.ReadInt32();
            break;
          }
          case 104: {
            MapSkillId = input.ReadInt32();
            break;
          }
          case 112: {
            BattleSkillId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
