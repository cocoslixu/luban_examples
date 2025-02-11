//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import bright.serialization.*;



public final class BinaryOperator extends cfg.ai.KeyQueryOperator {
    public BinaryOperator(ByteBuf _buf) { 
        super(_buf);
        oper = _buf.readInt();
        data = cfg.ai.KeyData.deserializeKeyData(_buf);
    }

    public BinaryOperator(int oper, cfg.ai.KeyData data ) {
        super();
        this.oper = oper;
        this.data = data;
    }


    public final int oper;
    public final cfg.ai.KeyData data;

    public static final int __ID__ = -979891605;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        if (data != null) {data.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "oper:" + oper + ","
        + "data:" + data + ","
        + "}";
    }
}
