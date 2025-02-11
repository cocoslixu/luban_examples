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



namespace cfg.item
{

public sealed partial class TreasureBox :  item.ItemExtra 
{
    public TreasureBox(JSONNode _json)  : base(_json) 
    {
        { var _j = _json["key_item_id"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  KeyItemId = _j; } } else { KeyItemId = null; } }
        { if(!_json["open_level"].IsObject) { throw new SerializationException(); }  OpenLevel = condition.MinLevel.DeserializeMinLevel(_json["open_level"]); }
        { if(!_json["use_on_obtain"].IsBoolean) { throw new SerializationException(); }  UseOnObtain = _json["use_on_obtain"]; }
        { var _json1 = _json["drop_ids"]; if(!_json1.IsArray) { throw new SerializationException(); } DropIds = new System.Collections.Generic.List<int>(_json1.Count); foreach(JSONNode __e in _json1.Children) { int __v;  { if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e; }  DropIds.Add(__v); }   }
        { var _json1 = _json["choose_list"]; if(!_json1.IsArray) { throw new SerializationException(); } ChooseList = new System.Collections.Generic.List<item.ChooseOneBonus>(_json1.Count); foreach(JSONNode __e in _json1.Children) { item.ChooseOneBonus __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = item.ChooseOneBonus.DeserializeChooseOneBonus(__e); }  ChooseList.Add(__v); }   }
        PostInit();
    }

    public TreasureBox(int id, int? key_item_id, condition.MinLevel open_level, bool use_on_obtain, System.Collections.Generic.List<int> drop_ids, System.Collections.Generic.List<item.ChooseOneBonus> choose_list )  : base(id) 
    {
        this.KeyItemId = key_item_id;
        this.OpenLevel = open_level;
        this.UseOnObtain = use_on_obtain;
        this.DropIds = drop_ids;
        this.ChooseList = choose_list;
        PostInit();
    }

    public static TreasureBox DeserializeTreasureBox(JSONNode _json)
    {
        return new item.TreasureBox(_json);
    }

    public int? KeyItemId { get; private set; }
    public condition.MinLevel OpenLevel { get; private set; }
    public bool UseOnObtain { get; private set; }
    public System.Collections.Generic.List<int> DropIds { get; private set; }
    public System.Collections.Generic.List<bonus.DropInfo> DropIds_Ref { get; private set; }
    public System.Collections.Generic.List<item.ChooseOneBonus> ChooseList { get; private set; }

    public const int __ID__ = 1494222369;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OpenLevel?.Resolve(_tables);
        { bonus.TbDrop __table = (bonus.TbDrop)_tables["bonus.TbDrop"]; this.DropIds_Ref = new System.Collections.Generic.List<bonus.DropInfo>(); foreach(var __e in DropIds) { this.DropIds_Ref.Add(__table.GetOrDefault(__e)); } }
        foreach(var _e in ChooseList) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        OpenLevel?.TranslateText(translator);
        foreach(var _e in ChooseList) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "KeyItemId:" + KeyItemId + ","
        + "OpenLevel:" + OpenLevel + ","
        + "UseOnObtain:" + UseOnObtain + ","
        + "DropIds:" + Bright.Common.StringUtil.CollectionToString(DropIds) + ","
        + "ChooseList:" + Bright.Common.StringUtil.CollectionToString(ChooseList) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
