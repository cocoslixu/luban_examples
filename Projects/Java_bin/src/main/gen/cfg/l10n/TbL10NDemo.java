//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.l10n;

import bright.serialization.*;


public final class TbL10NDemo {
    private final java.util.HashMap<Integer, cfg.l10n.L10NDemo> _dataMap;
    private final java.util.ArrayList<cfg.l10n.L10NDemo> _dataList;
    
    public TbL10NDemo(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.l10n.L10NDemo>();
        _dataList = new java.util.ArrayList<cfg.l10n.L10NDemo>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.l10n.L10NDemo _v;
            _v = new cfg.l10n.L10NDemo(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.l10n.L10NDemo> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.l10n.L10NDemo> getDataList() { return _dataList; }

    public cfg.l10n.L10NDemo get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.l10n.L10NDemo v : _dataList) {
            v.resolve(_tables);
        }
    }
}