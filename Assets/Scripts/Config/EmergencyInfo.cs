// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/EmergencyInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EmergencyInfo {

  /// <summary>Holder for reflection information generated from proto/EmergencyInfo.proto</summary>
  public static partial class EmergencyInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/EmergencyInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EmergencyInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlwcm90by9FbWVyZ2VuY3lJbmZvLnByb3RvEg1FbWVyZ2VuY3lJbmZvIocD",
            "ChNFbWVyZ2VuY3lJbmZvQ29uZmlnEk4KFGVtZXJnZW5jeUl0ZW1fY29uZmln",
            "GAEgAygLMjAuRW1lcmdlbmN5SW5mby5FbWVyZ2VuY3lJbmZvQ29uZmlnLkVt",
            "ZXJnZW5jeUl0ZW0azQEKDUVtZXJnZW5jeUl0ZW0SEwoLZW1lcmdlbmN5SWQY",
            "ASABKAMSDwoHcGljdHVyZRgCIAEoCRIMCgRuYW1lGAMgASgJEhMKC2Rlc2Ny",
            "aXB0aW9uGAQgASgJEhIKCnRpbWVPZmZzZXQYBSABKA0SFQoNZGVmYXVsdE9w",
            "dGlvbhgGIAEoBRI6CgdvcHRpb25zGAcgAygLMikuRW1lcmdlbmN5SW5mby5F",
            "bWVyZ2VuY3lJbmZvQ29uZmlnLk9wdGlvbhIMCgR0eXBlGAggASgFGlAKBk9w",
            "dGlvbhIMCgRuYW1lGAEgASgJEhMKC2Rlc2NyaXB0aW9uGAIgASgJEg8KB2Vm",
            "ZmVjdHMYAyADKAMSEgoKY29uZGl0aW9ucxgFIAMoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EmergencyInfo.EmergencyInfoConfig), global::EmergencyInfo.EmergencyInfoConfig.Parser, new[]{ "EmergencyItemConfig" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem), global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem.Parser, new[]{ "EmergencyId", "Picture", "Name", "Description", "TimeOffset", "DefaultOption", "Options", "Type" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::EmergencyInfo.EmergencyInfoConfig.Types.Option), global::EmergencyInfo.EmergencyInfoConfig.Types.Option.Parser, new[]{ "Name", "Description", "Effects", "Conditions" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// @wrapper 突发事件信息表(TriggerEvent.pb.json)
  /// </summary>
  public sealed partial class EmergencyInfoConfig : pb::IMessage<EmergencyInfoConfig> {
    private static readonly pb::MessageParser<EmergencyInfoConfig> _parser = new pb::MessageParser<EmergencyInfoConfig>(() => new EmergencyInfoConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmergencyInfoConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EmergencyInfo.EmergencyInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmergencyInfoConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmergencyInfoConfig(EmergencyInfoConfig other) : this() {
      emergencyItemConfig_ = other.emergencyItemConfig_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmergencyInfoConfig Clone() {
      return new EmergencyInfoConfig(this);
    }

    /// <summary>Field number for the "emergencyItem_config" field.</summary>
    public const int EmergencyItemConfigFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem> _repeated_emergencyItemConfig_codec
        = pb::FieldCodec.ForMessage(10, global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem.Parser);
    private readonly pbc::RepeatedField<global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem> emergencyItemConfig_ = new pbc::RepeatedField<global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem>();
    /// <summary>
    /// @name 突发事件配置
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::EmergencyInfo.EmergencyInfoConfig.Types.EmergencyItem> EmergencyItemConfig {
      get { return emergencyItemConfig_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmergencyInfoConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmergencyInfoConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!emergencyItemConfig_.Equals(other.emergencyItemConfig_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= emergencyItemConfig_.GetHashCode();
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
      emergencyItemConfig_.WriteTo(output, _repeated_emergencyItemConfig_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += emergencyItemConfig_.CalculateSize(_repeated_emergencyItemConfig_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmergencyInfoConfig other) {
      if (other == null) {
        return;
      }
      emergencyItemConfig_.Add(other.emergencyItemConfig_);
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
            emergencyItemConfig_.AddEntriesFrom(input, _repeated_emergencyItemConfig_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EmergencyInfoConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class EmergencyItem : pb::IMessage<EmergencyItem> {
        private static readonly pb::MessageParser<EmergencyItem> _parser = new pb::MessageParser<EmergencyItem>(() => new EmergencyItem());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<EmergencyItem> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EmergencyInfo.EmergencyInfoConfig.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EmergencyItem() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EmergencyItem(EmergencyItem other) : this() {
          emergencyId_ = other.emergencyId_;
          picture_ = other.picture_;
          name_ = other.name_;
          description_ = other.description_;
          timeOffset_ = other.timeOffset_;
          defaultOption_ = other.defaultOption_;
          options_ = other.options_.Clone();
          type_ = other.type_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EmergencyItem Clone() {
          return new EmergencyItem(this);
        }

        /// <summary>Field number for the "emergencyId" field.</summary>
        public const int EmergencyIdFieldNumber = 1;
        private long emergencyId_;
        /// <summary>
        /// @name 触发事件id
        /// @key
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long EmergencyId {
          get { return emergencyId_; }
          set {
            emergencyId_ = value;
          }
        }

        /// <summary>Field number for the "picture" field.</summary>
        public const int PictureFieldNumber = 2;
        private string picture_ = "";
        /// <summary>
        /// @name 图片
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Picture {
          get { return picture_; }
          set {
            picture_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 3;
        private string name_ = "";
        /// <summary>
        /// @name 名称
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "description" field.</summary>
        public const int DescriptionFieldNumber = 4;
        private string description_ = "";
        /// <summary>
        /// @name 事件描述
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Description {
          get { return description_; }
          set {
            description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "timeOffset" field.</summary>
        public const int TimeOffsetFieldNumber = 5;
        private uint timeOffset_;
        /// <summary>
        /// @name 产生时间
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint TimeOffset {
          get { return timeOffset_; }
          set {
            timeOffset_ = value;
          }
        }

        /// <summary>Field number for the "defaultOption" field.</summary>
        public const int DefaultOptionFieldNumber = 6;
        private int defaultOption_;
        /// <summary>
        /// @name 默认选项
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int DefaultOption {
          get { return defaultOption_; }
          set {
            defaultOption_ = value;
          }
        }

        /// <summary>Field number for the "options" field.</summary>
        public const int OptionsFieldNumber = 7;
        private static readonly pb::FieldCodec<global::EmergencyInfo.EmergencyInfoConfig.Types.Option> _repeated_options_codec
            = pb::FieldCodec.ForMessage(58, global::EmergencyInfo.EmergencyInfoConfig.Types.Option.Parser);
        private readonly pbc::RepeatedField<global::EmergencyInfo.EmergencyInfoConfig.Types.Option> options_ = new pbc::RepeatedField<global::EmergencyInfo.EmergencyInfoConfig.Types.Option>();
        /// <summary>
        /// @name 选项
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::EmergencyInfo.EmergencyInfoConfig.Types.Option> Options {
          get { return options_; }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 8;
        private int type_;
        /// <summary>
        /// @name 行动事件类型
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as EmergencyItem);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(EmergencyItem other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (EmergencyId != other.EmergencyId) return false;
          if (Picture != other.Picture) return false;
          if (Name != other.Name) return false;
          if (Description != other.Description) return false;
          if (TimeOffset != other.TimeOffset) return false;
          if (DefaultOption != other.DefaultOption) return false;
          if(!options_.Equals(other.options_)) return false;
          if (Type != other.Type) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (EmergencyId != 0L) hash ^= EmergencyId.GetHashCode();
          if (Picture.Length != 0) hash ^= Picture.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (Description.Length != 0) hash ^= Description.GetHashCode();
          if (TimeOffset != 0) hash ^= TimeOffset.GetHashCode();
          if (DefaultOption != 0) hash ^= DefaultOption.GetHashCode();
          hash ^= options_.GetHashCode();
          if (Type != 0) hash ^= Type.GetHashCode();
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
          if (EmergencyId != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(EmergencyId);
          }
          if (Picture.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Picture);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Name);
          }
          if (Description.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Description);
          }
          if (TimeOffset != 0) {
            output.WriteRawTag(40);
            output.WriteUInt32(TimeOffset);
          }
          if (DefaultOption != 0) {
            output.WriteRawTag(48);
            output.WriteInt32(DefaultOption);
          }
          options_.WriteTo(output, _repeated_options_codec);
          if (Type != 0) {
            output.WriteRawTag(64);
            output.WriteInt32(Type);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (EmergencyId != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(EmergencyId);
          }
          if (Picture.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Picture);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (Description.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
          }
          if (TimeOffset != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeOffset);
          }
          if (DefaultOption != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefaultOption);
          }
          size += options_.CalculateSize(_repeated_options_codec);
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(EmergencyItem other) {
          if (other == null) {
            return;
          }
          if (other.EmergencyId != 0L) {
            EmergencyId = other.EmergencyId;
          }
          if (other.Picture.Length != 0) {
            Picture = other.Picture;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.Description.Length != 0) {
            Description = other.Description;
          }
          if (other.TimeOffset != 0) {
            TimeOffset = other.TimeOffset;
          }
          if (other.DefaultOption != 0) {
            DefaultOption = other.DefaultOption;
          }
          options_.Add(other.options_);
          if (other.Type != 0) {
            Type = other.Type;
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
                EmergencyId = input.ReadInt64();
                break;
              }
              case 18: {
                Picture = input.ReadString();
                break;
              }
              case 26: {
                Name = input.ReadString();
                break;
              }
              case 34: {
                Description = input.ReadString();
                break;
              }
              case 40: {
                TimeOffset = input.ReadUInt32();
                break;
              }
              case 48: {
                DefaultOption = input.ReadInt32();
                break;
              }
              case 58: {
                options_.AddEntriesFrom(input, _repeated_options_codec);
                break;
              }
              case 64: {
                Type = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class Option : pb::IMessage<Option> {
        private static readonly pb::MessageParser<Option> _parser = new pb::MessageParser<Option>(() => new Option());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Option> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::EmergencyInfo.EmergencyInfoConfig.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Option() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Option(Option other) : this() {
          name_ = other.name_;
          description_ = other.description_;
          effects_ = other.effects_.Clone();
          conditions_ = other.conditions_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Option Clone() {
          return new Option(this);
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// @name 选项名称
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "description" field.</summary>
        public const int DescriptionFieldNumber = 2;
        private string description_ = "";
        /// <summary>
        /// @name 描述
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Description {
          get { return description_; }
          set {
            description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "effects" field.</summary>
        public const int EffectsFieldNumber = 3;
        private static readonly pb::FieldCodec<long> _repeated_effects_codec
            = pb::FieldCodec.ForInt64(26);
        private readonly pbc::RepeatedField<long> effects_ = new pbc::RepeatedField<long>();
        /// <summary>
        /// @name 效果
        /// @style inline
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<long> Effects {
          get { return effects_; }
        }

        /// <summary>Field number for the "conditions" field.</summary>
        public const int ConditionsFieldNumber = 5;
        private static readonly pb::FieldCodec<long> _repeated_conditions_codec
            = pb::FieldCodec.ForInt64(42);
        private readonly pbc::RepeatedField<long> conditions_ = new pbc::RepeatedField<long>();
        /// <summary>
        /// @name 条件
        /// @style inline
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<long> Conditions {
          get { return conditions_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Option);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Option other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Name != other.Name) return false;
          if (Description != other.Description) return false;
          if(!effects_.Equals(other.effects_)) return false;
          if(!conditions_.Equals(other.conditions_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (Description.Length != 0) hash ^= Description.GetHashCode();
          hash ^= effects_.GetHashCode();
          hash ^= conditions_.GetHashCode();
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
          if (Name.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Name);
          }
          if (Description.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Description);
          }
          effects_.WriteTo(output, _repeated_effects_codec);
          conditions_.WriteTo(output, _repeated_conditions_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (Description.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
          }
          size += effects_.CalculateSize(_repeated_effects_codec);
          size += conditions_.CalculateSize(_repeated_conditions_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Option other) {
          if (other == null) {
            return;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.Description.Length != 0) {
            Description = other.Description;
          }
          effects_.Add(other.effects_);
          conditions_.Add(other.conditions_);
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
                Name = input.ReadString();
                break;
              }
              case 18: {
                Description = input.ReadString();
                break;
              }
              case 26:
              case 24: {
                effects_.AddEntriesFrom(input, _repeated_effects_codec);
                break;
              }
              case 42:
              case 40: {
                conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
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
