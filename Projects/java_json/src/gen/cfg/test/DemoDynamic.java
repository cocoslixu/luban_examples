//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public abstract class DemoDynamic {
    public DemoDynamic(JsonObject __json__) { 
        x1 = __json__.get("x1").getAsInt();
    }

    public DemoDynamic(int x1 ) {
        this.x1 = x1;
    }

    public static DemoDynamic deserializeDemoDynamic(JsonObject __json__) {
        switch (__json__.get("$type").getAsString()) {
            case "DemoD2": return new cfg.test.DemoD2(__json__);
            case "DemoE1": return new cfg.test.DemoE1(__json__);
            case "test.login.RoleInfo": return new cfg.test.login.RoleInfo(__json__);
            case "DemoD5": return new cfg.test.DemoD5(__json__);
            default: throw new bright.serialization.SerializationException();
        }
    }

    public final int x1;

    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "x1:" + x1 + ","
        + "}";
    }
}
