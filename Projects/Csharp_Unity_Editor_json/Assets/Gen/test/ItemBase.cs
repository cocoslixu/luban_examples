//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace editor.cfg.test
{

public abstract partial class ItemBase :  Bright.Config.EditorBeanBase 
{
    public ItemBase()
    {
            Name = "";
            Desc = "";
    }


    public static ItemBase LoadJsonItemBase(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        ItemBase obj;
        switch (type)
        {
            case "test.Item":   
            case "Item":obj = new test.Item(); break;
            case "test.Equipment":   
            case "Equipment":obj = new test.Equipment(); break;
            case "test.Decorator":   
            case "Decorator":obj = new test.Decorator(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonItemBase(ItemBase _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

}
}
