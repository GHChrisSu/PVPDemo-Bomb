//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Proto/Player.proto
namespace ProtoData
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerC2S")]
  public partial class PlayerC2S : global::ProtoBuf.IExtensible
  {
    public PlayerC2S() {}
    
    private string _modelName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"modelName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string modelName
    {
      get { return _modelName; }
      set { _modelName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerS2C")]
  public partial class PlayerS2C : global::ProtoBuf.IExtensible
  {
    public PlayerS2C() {}
    
    private readonly global::System.Collections.Generic.List<PlayerS2C.PlayerData> _dataList = new global::System.Collections.Generic.List<PlayerS2C.PlayerData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dataList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PlayerS2C.PlayerData> dataList
    {
      get { return _dataList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerData")]
  public partial class PlayerData : global::ProtoBuf.IExtensible
  {
    public PlayerData() {}
    
    private string _username;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _modelName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"modelName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string modelName
    {
      get { return _modelName; }
      set { _modelName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerS2CEvt")]
  public partial class PlayerS2CEvt : global::ProtoBuf.IExtensible
  {
    public PlayerS2CEvt() {}
    
    private string _username;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _modelName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"modelName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string modelName
    {
      get { return _modelName; }
      set { _modelName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}