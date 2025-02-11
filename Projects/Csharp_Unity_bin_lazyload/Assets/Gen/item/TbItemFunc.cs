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

namespace cfg.item
{
   
    public partial class TbItemFunc
    {
        public static TbItemFunc Instance { get; private set; }
        private bool _readAll = false;
        private Dictionary<item.EMinorType, item.ItemFunction> _dataMap;
        private List<item.ItemFunction> _dataList;
        public Dictionary<item.EMinorType, item.ItemFunction> DataMap
        {
            get
            {
                if(!_readAll)
                {
                    ReadAll();
                    _readAll = true;
                }
                return _dataMap;
            }
        }
        public List<item.ItemFunction> DataList
        {
            get
            {
                if(!_readAll)
                {
                    ReadAll();
                    _readAll = true;
                }
                return _dataList;
            }
        }
        private Dictionary<item.EMinorType,int> _indexMap;
        public List<item.EMinorType> Indexes;
        private System.Func<ByteBuf> _dataLoader;

        private void ReadAll()
        {
            _dataList.Clear();
            foreach(var index in Indexes)
            {
                var v = Get(index);
                _dataMap[index] = v;
                _dataList.Add(v);
            }
        }

        public TbItemFunc(ByteBuf _buf, string _tbName, System.Func<string,  ByteBuf> _loader)
        {
            Instance = this;
            _dataMap = new Dictionary<item.EMinorType, item.ItemFunction>();
            _dataList = new List<item.ItemFunction>();
            _indexMap = new Dictionary<item.EMinorType, int>();
            _dataLoader = new System.Func<ByteBuf>(() => _loader(_tbName));

            for (int n = _buf.ReadSize(); n > 0; --n)
            {
                item.EMinorType key;
                key = (item.EMinorType)_buf.ReadInt();
                int index = _buf.ReadInt();
                _indexMap[key] = index;
            }
            Indexes = _indexMap.Keys.ToList();
            PostInit();
        }

        public item.ItemFunction this[item.EMinorType key] => Get(key);
        public item.ItemFunction Get(item.EMinorType key)
        {
            item.ItemFunction _v;
            if(_dataMap.TryGetValue(key, out _v))
            {
                return _v;
            }
            ResetByteBuf(_indexMap[key]);
            _v = item.ItemFunction.DeserializeItemFunction(_buf);
            _dataMap[_v.MinorType] = _v;
            _v.Resolve(tables);
            if(_indexMap.Count == _dataMap.Count)
            {
                _buf = null;
            }
            return _v;
        }
        public item.ItemFunction GetOrDefault(item.EMinorType key)
        {
            if(_indexMap.TryGetValue(key,out var _))
            {
                return Get(key);
            }
            return null;
        }
        
        private void ResetByteBuf(int readerInex = 0)
        {
            if( _buf == null)
            {
                    if (_buf == null)
            {
                _buf = _dataLoader();
            }
            }
            _buf.ReaderIndex = readerInex;
        }
    
        private ByteBuf _buf = null;
        private Dictionary<string, object> tables;
        public void CacheTables(Dictionary<string, object> _tables)
        {
            tables = _tables;
        }
        partial void PostInit();
    }
} 