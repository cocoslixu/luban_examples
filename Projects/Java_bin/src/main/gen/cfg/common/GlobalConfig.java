//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.common;

import bright.serialization.*;



public final class GlobalConfig {
    public GlobalConfig(ByteBuf _buf) { 
        bagCapacity = _buf.readInt();
        bagCapacitySpecial = _buf.readInt();
        bagTempExpendableCapacity = _buf.readInt();
        bagTempToolCapacity = _buf.readInt();
        bagInitCapacity = _buf.readInt();
        quickBagCapacity = _buf.readInt();
        clothBagCapacity = _buf.readInt();
        clothBagInitCapacity = _buf.readInt();
        clothBagCapacitySpecial = _buf.readInt();
        if(_buf.readBool()){ bagInitItemsDropId = _buf.readInt(); } else { bagInitItemsDropId = null; }
        mailBoxCapacity = _buf.readInt();
        damageParamC = _buf.readFloat();
        damageParamE = _buf.readFloat();
        damageParamF = _buf.readFloat();
        damageParamD = _buf.readFloat();
        roleSpeed = _buf.readFloat();
        monsterSpeed = _buf.readFloat();
        initEnergy = _buf.readInt();
        initViality = _buf.readInt();
        maxViality = _buf.readInt();
        perVialityRecoveryTime = _buf.readInt();
    }

    public GlobalConfig(int bag_capacity, int bag_capacity_special, int bag_temp_expendable_capacity, int bag_temp_tool_capacity, int bag_init_capacity, int quick_bag_capacity, int cloth_bag_capacity, int cloth_bag_init_capacity, int cloth_bag_capacity_special, Integer bag_init_items_drop_id, int mail_box_capacity, float damage_param_c, float damage_param_e, float damage_param_f, float damage_param_d, float role_speed, float monster_speed, int init_energy, int init_viality, int max_viality, int per_viality_recovery_time ) {
        this.bagCapacity = bag_capacity;
        this.bagCapacitySpecial = bag_capacity_special;
        this.bagTempExpendableCapacity = bag_temp_expendable_capacity;
        this.bagTempToolCapacity = bag_temp_tool_capacity;
        this.bagInitCapacity = bag_init_capacity;
        this.quickBagCapacity = quick_bag_capacity;
        this.clothBagCapacity = cloth_bag_capacity;
        this.clothBagInitCapacity = cloth_bag_init_capacity;
        this.clothBagCapacitySpecial = cloth_bag_capacity_special;
        this.bagInitItemsDropId = bag_init_items_drop_id;
        this.mailBoxCapacity = mail_box_capacity;
        this.damageParamC = damage_param_c;
        this.damageParamE = damage_param_e;
        this.damageParamF = damage_param_f;
        this.damageParamD = damage_param_d;
        this.roleSpeed = role_speed;
        this.monsterSpeed = monster_speed;
        this.initEnergy = init_energy;
        this.initViality = init_viality;
        this.maxViality = max_viality;
        this.perVialityRecoveryTime = per_viality_recovery_time;
    }


    /**
     * 背包容量
     */
    public final int bagCapacity;
    public final int bagCapacitySpecial;
    public final int bagTempExpendableCapacity;
    public final int bagTempToolCapacity;
    public final int bagInitCapacity;
    public final int quickBagCapacity;
    public final int clothBagCapacity;
    public final int clothBagInitCapacity;
    public final int clothBagCapacitySpecial;
    public final Integer bagInitItemsDropId;
    public cfg.bonus.DropInfo bagInitItemsDropId_Ref;
    public final int mailBoxCapacity;
    public final float damageParamC;
    public final float damageParamE;
    public final float damageParamF;
    public final float damageParamD;
    public final float roleSpeed;
    public final float monsterSpeed;
    public final int initEnergy;
    public final int initViality;
    public final int maxViality;
    public final int perVialityRecoveryTime;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        this.bagInitItemsDropId_Ref = this.bagInitItemsDropId != null ? ((cfg.bonus.TbDrop)_tables.get("bonus.TbDrop")).get(bagInitItemsDropId) : null;
    }

    @Override
    public String toString() {
        return "{ "
        + "bagCapacity:" + bagCapacity + ","
        + "bagCapacitySpecial:" + bagCapacitySpecial + ","
        + "bagTempExpendableCapacity:" + bagTempExpendableCapacity + ","
        + "bagTempToolCapacity:" + bagTempToolCapacity + ","
        + "bagInitCapacity:" + bagInitCapacity + ","
        + "quickBagCapacity:" + quickBagCapacity + ","
        + "clothBagCapacity:" + clothBagCapacity + ","
        + "clothBagInitCapacity:" + clothBagInitCapacity + ","
        + "clothBagCapacitySpecial:" + clothBagCapacitySpecial + ","
        + "bagInitItemsDropId:" + bagInitItemsDropId + ","
        + "mailBoxCapacity:" + mailBoxCapacity + ","
        + "damageParamC:" + damageParamC + ","
        + "damageParamE:" + damageParamE + ","
        + "damageParamF:" + damageParamF + ","
        + "damageParamD:" + damageParamD + ","
        + "roleSpeed:" + roleSpeed + ","
        + "monsterSpeed:" + monsterSpeed + ","
        + "initEnergy:" + initEnergy + ","
        + "initViality:" + initViality + ","
        + "maxViality:" + maxViality + ","
        + "perVialityRecoveryTime:" + perVialityRecoveryTime + ","
        + "}";
    }
}
