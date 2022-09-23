//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{

public sealed partial class MultiRoleCondition :  condition.RoleCondition 
{
    public MultiRoleCondition(ByteBuf _buf)  : base(_buf) 
    {
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Conditions = new condition.RoleCondition[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { condition.RoleCondition __e0;__e0 = condition.RoleCondition.DeserializeRoleCondition(_buf); Conditions[__index0] = __e0;}}
        PostInit();
    }

    public static MultiRoleCondition DeserializeMultiRoleCondition(ByteBuf _buf)
    {
        return new condition.MultiRoleCondition(_buf);
    }

    public condition.RoleCondition[] Conditions { get; private set; }

    public const int __ID__ = 934079583;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Conditions) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Conditions) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Conditions:" + Bright.Common.StringUtil.CollectionToString(Conditions) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}