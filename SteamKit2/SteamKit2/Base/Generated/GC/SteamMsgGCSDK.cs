//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: gcsdk_gcmessages.proto
namespace SteamKit2.GC.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOSingleObject")]
  public partial class CMsgSOSingleObject : global::ProtoBuf.IExtensible
  {
    public CMsgSOSingleObject() {}
    

    private ulong _owner = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong owner
    {
      get { return _owner; }
      set { _owner = value; }
    }

    private int _type_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(int))]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }

    private byte[] _object_data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"object_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(null)]
    public byte[] object_data
    {
      get { return _object_data; }
      set { _object_data = value; }
    }

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOMultipleObjects")]
  public partial class CMsgSOMultipleObjects : global::ProtoBuf.IExtensible
  {
    public CMsgSOMultipleObjects() {}
    

    private ulong _owner = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong owner
    {
      get { return _owner; }
      set { _owner = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> _objects = new global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject>();
    [global::ProtoBuf.ProtoMember(2, Name=@"objects", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> objects
    {
      get { return _objects; }
    }
  

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SingleObject")]
  public partial class SingleObject : global::ProtoBuf.IExtensible
  {
    public SingleObject() {}
    

    private int _type_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(int))]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }

    private byte[] _object_data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"object_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(null)]
    public byte[] object_data
    {
      get { return _object_data; }
      set { _object_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheSubscribed")]
  public partial class CMsgSOCacheSubscribed : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheSubscribed() {}
    

    private ulong _owner = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong owner
    {
      get { return _owner; }
      set { _owner = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgSOCacheSubscribed.SubscribedType> _objects = new global::System.Collections.Generic.List<CMsgSOCacheSubscribed.SubscribedType>();
    [global::ProtoBuf.ProtoMember(2, Name=@"objects", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOCacheSubscribed.SubscribedType> objects
    {
      get { return _objects; }
    }
  

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubscribedType")]
  public partial class SubscribedType : global::ProtoBuf.IExtensible
  {
    public SubscribedType() {}
    

    private int _type_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(int))]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _object_data = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(2, Name=@"object_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> object_data
    {
      get { return _object_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheUnsubscribed")]
  public partial class CMsgSOCacheUnsubscribed : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheUnsubscribed() {}
    

    private ulong _owner = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong owner
    {
      get { return _owner; }
      set { _owner = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheSubscriptionCheck")]
  public partial class CMsgSOCacheSubscriptionCheck : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheSubscriptionCheck() {}
    

    private ulong _owner = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong owner
    {
      get { return _owner; }
      set { _owner = value; }
    }

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheSubscriptionRefresh")]
  public partial class CMsgSOCacheSubscriptionRefresh : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheSubscriptionRefresh() {}
    

    private ulong _owner = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong owner
    {
      get { return _owner; }
      set { _owner = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheVersion")]
  public partial class CMsgSOCacheVersion : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheVersion() {}
    

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgAccountDetails")]
  public partial class CMsgAccountDetails : global::ProtoBuf.IExtensible
  {
    public CMsgAccountDetails() {}
    

    private bool _valid = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool valid
    {
      get { return _valid; }
      set { _valid = value; }
    }

    private string _account_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string account_name
    {
      get { return _account_name; }
      set { _account_name = value; }
    }

    private string _persona_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"persona_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string persona_name
    {
      get { return _persona_name; }
      set { _persona_name = value; }
    }

    private bool _public_profile = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"public_profile", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool public_profile
    {
      get { return _public_profile; }
      set { _public_profile = value; }
    }

    private bool _public_inventory = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"public_inventory", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool public_inventory
    {
      get { return _public_inventory; }
      set { _public_inventory = value; }
    }

    private bool _vac_banned = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"vac_banned", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool vac_banned
    {
      get { return _vac_banned; }
      set { _vac_banned = value; }
    }

    private bool _cyber_cafe = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"cyber_cafe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool cyber_cafe
    {
      get { return _cyber_cafe; }
      set { _cyber_cafe = value; }
    }

    private bool _school_account = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"school_account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool school_account
    {
      get { return _school_account; }
      set { _school_account = value; }
    }

    private bool _free_trial_account = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"free_trial_account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool free_trial_account
    {
      get { return _free_trial_account; }
      set { _free_trial_account = value; }
    }

    private bool _subscribed = default(bool);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"subscribed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool subscribed
    {
      get { return _subscribed; }
      set { _subscribed = value; }
    }

    private bool _low_violence = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"low_violence", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool low_violence
    {
      get { return _low_violence; }
      set { _low_violence = value; }
    }

    private bool _limited = default(bool);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"limited", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool limited
    {
      get { return _limited; }
      set { _limited = value; }
    }

    private bool _trusted = default(bool);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"trusted", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool trusted
    {
      get { return _trusted; }
      set { _trusted = value; }
    }

    private uint _package = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"package", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint package
    {
      get { return _package; }
      set { _package = value; }
    }

    private uint _time_cached = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"time_cached", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint time_cached
    {
      get { return _time_cached; }
      set { _time_cached = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
#pragma warning restore 1591
