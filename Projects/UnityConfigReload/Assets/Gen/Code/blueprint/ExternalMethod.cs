//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.blueprint
{

public sealed partial class ExternalMethod :  blueprint.Method 
{
    public ExternalMethod(ByteBuf _buf)  : base(_buf) 
    {
        PostInit();
    }

    public static ExternalMethod DeserializeExternalMethod(ByteBuf _buf)
    {
        return new blueprint.ExternalMethod(_buf);
    }


    public const int __ID__ = 1739079015;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(ExternalMethod reloadData)
    {
        Name = reloadData.Name;
        Desc = reloadData.Desc;
        IsStatic = reloadData.IsStatic;
        ReturnType = reloadData.ReturnType;
        if(Parameters==null)
        {
            Parameters = reloadData.Parameters;
        }else
        {
            Parameters.Capacity = reloadData.Parameters.Count;
            for (int i = 0; i < reloadData.Parameters.Count; i++)
            {
                if(Parameters[i]!=null)
                {
                    Parameters[i].Reload(reloadData.Parameters[i]);
                }else
                {
                    Parameters[i] = reloadData.Parameters[i];
                }
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "ReturnType:" + ReturnType + ","
        + "Parameters:" + Bright.Common.StringUtil.CollectionToString(Parameters) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
