//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: gcsdk_gcmessages.proto
namespace SteamKit2.GC
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
  
}