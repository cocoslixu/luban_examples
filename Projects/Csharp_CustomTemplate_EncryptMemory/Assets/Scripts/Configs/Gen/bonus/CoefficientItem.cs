
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using Scripts;







namespace cfg.bonus
{
    [Serializable]
    public partial class CoefficientItem : AConfig
    {
        [JsonProperty("bonus_id")]
        private int _bonus_id { get; set; }
        [JsonIgnore]
        public EncryptInt bonus_id { get; private set; } = new();

        [JsonProperty]
        public bonus.Items  bonus_list { get; set; }


        public override void EndInit() 
        {
            bonus_id = _bonus_id;
            bonus_list.EndInit();
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
