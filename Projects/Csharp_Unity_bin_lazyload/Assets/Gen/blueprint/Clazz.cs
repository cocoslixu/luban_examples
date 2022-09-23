//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.blueprint
{

public abstract partial class Clazz :  Bright.Config.BeanBase 
{
    public Clazz(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Parents = new System.Collections.Generic.List<blueprint.Clazz>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { blueprint.Clazz _e0;  _e0 = blueprint.Clazz.DeserializeClazz(_buf); Parents.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Methods = new System.Collections.Generic.List<blueprint.Method>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { blueprint.Method _e0;  _e0 = blueprint.Method.DeserializeMethod(_buf); Methods.Add(_e0);}}
        PostInit();
    }

    public static Clazz DeserializeClazz(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case blueprint.Interface.__ID__: return new blueprint.Interface(_buf);
            case blueprint.NormalClazz.__ID__: return new blueprint.NormalClazz(_buf);
            case blueprint.EnumClazz.__ID__: return new blueprint.EnumClazz(_buf);
            default: throw new SerializationException();
        }
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public System.Collections.Generic.List<blueprint.Clazz> Parents { get; private set; }
    public System.Collections.Generic.List<blueprint.Method> Methods { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parents) { _e?.Resolve(_tables); }
        foreach(var _e in Methods) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Parents) { _e?.TranslateText(translator); }
        foreach(var _e in Methods) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}