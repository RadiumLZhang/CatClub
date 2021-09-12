// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/HumanInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HumanInfo {

  /// <summary>Holder for reflection information generated from proto/HumanInfo.proto</summary>
  public static partial class HumanInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/HumanInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HumanInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVwcm90by9IdW1hbkluZm8ucHJvdG8SCUh1bWFuSW5mbyKwAgoJSHVtYW5J",
            "bmZvEisKBnBlb3BsZRgBIAMoCzIbLkh1bWFuSW5mby5IdW1hbkluZm8ucGVy",
            "c29uGvUBCgZwZXJzb24SDwoHaHVtYW5JZBgBIAEoAxIMCgRuYW1lGAIgASgJ",
            "Eg0KBXRpdGxlGAMgASgJEg0KBWltYWdlGAQgASgJEgsKA3NleBgFIAEoBRIT",
            "Cgtpc0ltcG9ydGFudBgGIAEoBRITCgtjYW5SYWlzZUNhdBgHIAEoBRITCgtj",
            "YW5XYXNoSGVhZBgIIAEoBRIUCgxkZWZhdWx0Q2F0SWQYCSABKAMSDAoEdGFn",
            "cxgKIAMoAxISCgp2aXNpYmlsaXR5GAsgASgFEhYKDnRlbmRUb1JhaXNlQ2F0",
            "GAwgASgFEhIKCkZhdm9yVmFsdWUYDSABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HumanInfo.HumanInfo), global::HumanInfo.HumanInfo.Parser, new[]{ "People" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::HumanInfo.HumanInfo.Types.person), global::HumanInfo.HumanInfo.Types.person.Parser, new[]{ "HumanId", "Name", "Title", "Image", "Sex", "IsImportant", "CanRaiseCat", "CanWashHead", "DefaultCatId", "Tags", "Visibility", "TendToRaiseCat", "FavorValue" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// @wrapper 人类信息表(HumanInfo.pb.json)
  /// </summary>
  public sealed partial class HumanInfo : pb::IMessage<HumanInfo> {
    private static readonly pb::MessageParser<HumanInfo> _parser = new pb::MessageParser<HumanInfo>(() => new HumanInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HumanInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HumanInfo.HumanInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HumanInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HumanInfo(HumanInfo other) : this() {
      people_ = other.people_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HumanInfo Clone() {
      return new HumanInfo(this);
    }

    /// <summary>Field number for the "people" field.</summary>
    public const int PeopleFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HumanInfo.HumanInfo.Types.person> _repeated_people_codec
        = pb::FieldCodec.ForMessage(10, global::HumanInfo.HumanInfo.Types.person.Parser);
    private readonly pbc::RepeatedField<global::HumanInfo.HumanInfo.Types.person> people_ = new pbc::RepeatedField<global::HumanInfo.HumanInfo.Types.person>();
    /// <summary>
    /// @name 人类信息配置
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HumanInfo.HumanInfo.Types.person> People {
      get { return people_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HumanInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HumanInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!people_.Equals(other.people_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= people_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      people_.WriteTo(output, _repeated_people_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += people_.CalculateSize(_repeated_people_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HumanInfo other) {
      if (other == null) {
        return;
      }
      people_.Add(other.people_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            people_.AddEntriesFrom(input, _repeated_people_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the HumanInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class person : pb::IMessage<person> {
        private static readonly pb::MessageParser<person> _parser = new pb::MessageParser<person>(() => new person());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<person> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::HumanInfo.HumanInfo.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public person() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public person(person other) : this() {
          humanId_ = other.humanId_;
          name_ = other.name_;
          title_ = other.title_;
          image_ = other.image_;
          sex_ = other.sex_;
          isImportant_ = other.isImportant_;
          canRaiseCat_ = other.canRaiseCat_;
          canWashHead_ = other.canWashHead_;
          defaultCatId_ = other.defaultCatId_;
          tags_ = other.tags_.Clone();
          visibility_ = other.visibility_;
          tendToRaiseCat_ = other.tendToRaiseCat_;
          favorValue_ = other.favorValue_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public person Clone() {
          return new person(this);
        }

        /// <summary>Field number for the "humanId" field.</summary>
        public const int HumanIdFieldNumber = 1;
        private long humanId_;
        /// <summary>
        /// @name 人物编号
        /// @key
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long HumanId {
          get { return humanId_; }
          set {
            humanId_ = value;
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 2;
        private string name_ = "";
        /// <summary>
        /// @name 姓名
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "title" field.</summary>
        public const int TitleFieldNumber = 3;
        private string title_ = "";
        /// <summary>
        /// @name 头衔
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Title {
          get { return title_; }
          set {
            title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "image" field.</summary>
        public const int ImageFieldNumber = 4;
        private string image_ = "";
        /// <summary>
        /// @name 头像
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Image {
          get { return image_; }
          set {
            image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "sex" field.</summary>
        public const int SexFieldNumber = 5;
        private int sex_;
        /// <summary>
        /// @name 性别
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Sex {
          get { return sex_; }
          set {
            sex_ = value;
          }
        }

        /// <summary>Field number for the "isImportant" field.</summary>
        public const int IsImportantFieldNumber = 6;
        private int isImportant_;
        /// <summary>
        /// @name 是否为主要人物
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int IsImportant {
          get { return isImportant_; }
          set {
            isImportant_ = value;
          }
        }

        /// <summary>Field number for the "canRaiseCat" field.</summary>
        public const int CanRaiseCatFieldNumber = 7;
        private int canRaiseCat_;
        /// <summary>
        /// @name 能否养猫
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CanRaiseCat {
          get { return canRaiseCat_; }
          set {
            canRaiseCat_ = value;
          }
        }

        /// <summary>Field number for the "canWashHead" field.</summary>
        public const int CanWashHeadFieldNumber = 8;
        private int canWashHead_;
        /// <summary>
        /// @name 能否洗脑
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CanWashHead {
          get { return canWashHead_; }
          set {
            canWashHead_ = value;
          }
        }

        /// <summary>Field number for the "defaultCatId" field.</summary>
        public const int DefaultCatIdFieldNumber = 9;
        private long defaultCatId_;
        /// <summary>
        /// @name 默认养猫编号
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long DefaultCatId {
          get { return defaultCatId_; }
          set {
            defaultCatId_ = value;
          }
        }

        /// <summary>Field number for the "tags" field.</summary>
        public const int TagsFieldNumber = 10;
        private static readonly pb::FieldCodec<long> _repeated_tags_codec
            = pb::FieldCodec.ForInt64(82);
        private readonly pbc::RepeatedField<long> tags_ = new pbc::RepeatedField<long>();
        /// <summary>
        /// @name 标签
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<long> Tags {
          get { return tags_; }
        }

        /// <summary>Field number for the "visibility" field.</summary>
        public const int VisibilityFieldNumber = 11;
        private int visibility_;
        /// <summary>
        /// @name 初始能见度
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Visibility {
          get { return visibility_; }
          set {
            visibility_ = value;
          }
        }

        /// <summary>Field number for the "tendToRaiseCat" field.</summary>
        public const int TendToRaiseCatFieldNumber = 12;
        private int tendToRaiseCat_;
        /// <summary>
        /// @name 初始养猫意向
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int TendToRaiseCat {
          get { return tendToRaiseCat_; }
          set {
            tendToRaiseCat_ = value;
          }
        }

        /// <summary>Field number for the "FavorValue" field.</summary>
        public const int FavorValueFieldNumber = 13;
        private int favorValue_;
        /// <summary>
        /// @name 初始亲密度
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int FavorValue {
          get { return favorValue_; }
          set {
            favorValue_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as person);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(person other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (HumanId != other.HumanId) return false;
          if (Name != other.Name) return false;
          if (Title != other.Title) return false;
          if (Image != other.Image) return false;
          if (Sex != other.Sex) return false;
          if (IsImportant != other.IsImportant) return false;
          if (CanRaiseCat != other.CanRaiseCat) return false;
          if (CanWashHead != other.CanWashHead) return false;
          if (DefaultCatId != other.DefaultCatId) return false;
          if(!tags_.Equals(other.tags_)) return false;
          if (Visibility != other.Visibility) return false;
          if (TendToRaiseCat != other.TendToRaiseCat) return false;
          if (FavorValue != other.FavorValue) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (HumanId != 0L) hash ^= HumanId.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (Title.Length != 0) hash ^= Title.GetHashCode();
          if (Image.Length != 0) hash ^= Image.GetHashCode();
          if (Sex != 0) hash ^= Sex.GetHashCode();
          if (IsImportant != 0) hash ^= IsImportant.GetHashCode();
          if (CanRaiseCat != 0) hash ^= CanRaiseCat.GetHashCode();
          if (CanWashHead != 0) hash ^= CanWashHead.GetHashCode();
          if (DefaultCatId != 0L) hash ^= DefaultCatId.GetHashCode();
          hash ^= tags_.GetHashCode();
          if (Visibility != 0) hash ^= Visibility.GetHashCode();
          if (TendToRaiseCat != 0) hash ^= TendToRaiseCat.GetHashCode();
          if (FavorValue != 0) hash ^= FavorValue.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (HumanId != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(HumanId);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Name);
          }
          if (Title.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Title);
          }
          if (Image.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Image);
          }
          if (Sex != 0) {
            output.WriteRawTag(40);
            output.WriteInt32(Sex);
          }
          if (IsImportant != 0) {
            output.WriteRawTag(48);
            output.WriteInt32(IsImportant);
          }
          if (CanRaiseCat != 0) {
            output.WriteRawTag(56);
            output.WriteInt32(CanRaiseCat);
          }
          if (CanWashHead != 0) {
            output.WriteRawTag(64);
            output.WriteInt32(CanWashHead);
          }
          if (DefaultCatId != 0L) {
            output.WriteRawTag(72);
            output.WriteInt64(DefaultCatId);
          }
          tags_.WriteTo(output, _repeated_tags_codec);
          if (Visibility != 0) {
            output.WriteRawTag(88);
            output.WriteInt32(Visibility);
          }
          if (TendToRaiseCat != 0) {
            output.WriteRawTag(96);
            output.WriteInt32(TendToRaiseCat);
          }
          if (FavorValue != 0) {
            output.WriteRawTag(104);
            output.WriteInt32(FavorValue);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (HumanId != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(HumanId);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (Title.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
          }
          if (Image.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Image);
          }
          if (Sex != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Sex);
          }
          if (IsImportant != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(IsImportant);
          }
          if (CanRaiseCat != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(CanRaiseCat);
          }
          if (CanWashHead != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(CanWashHead);
          }
          if (DefaultCatId != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(DefaultCatId);
          }
          size += tags_.CalculateSize(_repeated_tags_codec);
          if (Visibility != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Visibility);
          }
          if (TendToRaiseCat != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(TendToRaiseCat);
          }
          if (FavorValue != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(FavorValue);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(person other) {
          if (other == null) {
            return;
          }
          if (other.HumanId != 0L) {
            HumanId = other.HumanId;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.Title.Length != 0) {
            Title = other.Title;
          }
          if (other.Image.Length != 0) {
            Image = other.Image;
          }
          if (other.Sex != 0) {
            Sex = other.Sex;
          }
          if (other.IsImportant != 0) {
            IsImportant = other.IsImportant;
          }
          if (other.CanRaiseCat != 0) {
            CanRaiseCat = other.CanRaiseCat;
          }
          if (other.CanWashHead != 0) {
            CanWashHead = other.CanWashHead;
          }
          if (other.DefaultCatId != 0L) {
            DefaultCatId = other.DefaultCatId;
          }
          tags_.Add(other.tags_);
          if (other.Visibility != 0) {
            Visibility = other.Visibility;
          }
          if (other.TendToRaiseCat != 0) {
            TendToRaiseCat = other.TendToRaiseCat;
          }
          if (other.FavorValue != 0) {
            FavorValue = other.FavorValue;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                HumanId = input.ReadInt64();
                break;
              }
              case 18: {
                Name = input.ReadString();
                break;
              }
              case 26: {
                Title = input.ReadString();
                break;
              }
              case 34: {
                Image = input.ReadString();
                break;
              }
              case 40: {
                Sex = input.ReadInt32();
                break;
              }
              case 48: {
                IsImportant = input.ReadInt32();
                break;
              }
              case 56: {
                CanRaiseCat = input.ReadInt32();
                break;
              }
              case 64: {
                CanWashHead = input.ReadInt32();
                break;
              }
              case 72: {
                DefaultCatId = input.ReadInt64();
                break;
              }
              case 82:
              case 80: {
                tags_.AddEntriesFrom(input, _repeated_tags_codec);
                break;
              }
              case 88: {
                Visibility = input.ReadInt32();
                break;
              }
              case 96: {
                TendToRaiseCat = input.ReadInt32();
                break;
              }
              case 104: {
                FavorValue = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code