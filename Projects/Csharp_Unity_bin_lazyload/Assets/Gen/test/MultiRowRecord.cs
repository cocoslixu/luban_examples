//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class MultiRowRecord :  Bright.Config.BeanBase 
{
    public MultiRowRecord(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);OneRows = new System.Collections.Generic.List<test.MultiRowType1>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.MultiRowType1 _e0;  _e0 = test.MultiRowType1.DeserializeMultiRowType1(_buf); OneRows.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows1 = new System.Collections.Generic.List<test.MultiRowType1>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.MultiRowType1 _e0;  _e0 = test.MultiRowType1.DeserializeMultiRowType1(_buf); MultiRows1.Add(_e0);}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows2 = new test.MultiRowType1[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { test.MultiRowType1 __e0;__e0 = test.MultiRowType1.DeserializeMultiRowType1(_buf); MultiRows2[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows4 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); test.MultiRowType2 _v0;  _v0 = test.MultiRowType2.DeserializeMultiRowType2(_buf);     MultiRows4.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows5 = new System.Collections.Generic.List<test.MultiRowType3>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.MultiRowType3 _e0;  _e0 = test.MultiRowType3.DeserializeMultiRowType3(_buf); MultiRows5.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows6 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); test.MultiRowType2 _v0;  _v0 = test.MultiRowType2.DeserializeMultiRowType2(_buf);     MultiRows6.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows7 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     MultiRows7.Add(_k0, _v0);}}
        PostInit();
    }

    public static MultiRowRecord DeserializeMultiRowRecord(ByteBuf _buf)
    {
        return new test.MultiRowRecord(_buf);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public System.Collections.Generic.List<test.MultiRowType1> OneRows { get; private set; }
    public System.Collections.Generic.List<test.MultiRowType1> MultiRows1 { get; private set; }
    public test.MultiRowType1[] MultiRows2 { get; private set; }
    public System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows4 { get; private set; }
    public System.Collections.Generic.List<test.MultiRowType3> MultiRows5 { get; private set; }
    public System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows6 { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> MultiRows7 { get; private set; }

    public const int __ID__ = -501249394;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in OneRows) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows1) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows2) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows4.Values) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows5) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows6.Values) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in OneRows) { _e?.TranslateText(translator); }
        foreach(var _e in MultiRows1) { _e?.TranslateText(translator); }
        foreach(var _e in MultiRows2) { _e?.TranslateText(translator); }
        foreach(var _e in MultiRows4.Values) { _e?.TranslateText(translator); }
        foreach(var _e in MultiRows5) { _e?.TranslateText(translator); }
        foreach(var _e in MultiRows6.Values) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "OneRows:" + Bright.Common.StringUtil.CollectionToString(OneRows) + ","
        + "MultiRows1:" + Bright.Common.StringUtil.CollectionToString(MultiRows1) + ","
        + "MultiRows2:" + Bright.Common.StringUtil.CollectionToString(MultiRows2) + ","
        + "MultiRows4:" + Bright.Common.StringUtil.CollectionToString(MultiRows4) + ","
        + "MultiRows5:" + Bright.Common.StringUtil.CollectionToString(MultiRows5) + ","
        + "MultiRows6:" + Bright.Common.StringUtil.CollectionToString(MultiRows6) + ","
        + "MultiRows7:" + Bright.Common.StringUtil.CollectionToString(MultiRows7) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}