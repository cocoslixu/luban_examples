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

namespace cfg.test
{
   
    public partial class TbDefineFromExcel2
    {
        public static TbDefineFromExcel2 Instance { get; private set; }
        private bool _readAll = false;
        private Dictionary<int, test.DefineFromExcel2> _dataMap;
        private List<test.DefineFromExcel2> _dataList;
        public Dictionary<int, test.DefineFromExcel2> DataMap
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
        public List<test.DefineFromExcel2> DataList
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
        private Dictionary<int,int> _indexMap;
        public List<int> Indexes;
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

        public TbDefineFromExcel2(ByteBuf _buf, string _tbName, System.Func<string,  ByteBuf> _loader)
        {
            Instance = this;
            _dataMap = new Dictionary<int, test.DefineFromExcel2>();
            _dataList = new List<test.DefineFromExcel2>();
            _indexMap = new Dictionary<int, int>();
            _dataLoader = new System.Func<ByteBuf>(() => _loader(_tbName));

            for (int n = _buf.ReadSize(); n > 0; --n)
            {
                int key;
                key = _buf.ReadInt();
                int index = _buf.ReadInt();
                _indexMap[key] = index;
            }
            Indexes = _indexMap.Keys.ToList();
            PostInit();
        }

        public test.DefineFromExcel2 this[int key] => Get(key);
        public test.DefineFromExcel2 Get(int key)
        {
            test.DefineFromExcel2 _v;
            if(_dataMap.TryGetValue(key, out _v))
            {
                return _v;
            }
            ResetByteBuf(_indexMap[key]);
            _v = test.DefineFromExcel2.DeserializeDefineFromExcel2(_buf);
            _dataMap[_v.Id] = _v;
            _v.Resolve(tables);
            if(_indexMap.Count == _dataMap.Count)
            {
                _buf = null;
            }
            return _v;
        }
        public test.DefineFromExcel2 GetOrDefault(int key)
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