
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type TestMultiRowType3 struct {
    Id int32
    Items []*TestMultiRowType1
}

const TypeId_TestMultiRowType3 = 540474972

func (*TestMultiRowType3) GetTypeId() int32 {
    return 540474972
}

func (_v *TestMultiRowType3)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestMultiRowType3)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    {_v.Items = make([]*TestMultiRowType1, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Items error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ *TestMultiRowType1; { if _e_, err = DeserializeTestMultiRowType1(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Items = append(_v.Items, _e_) } }
    return
}

func DeserializeTestMultiRowType3(_buf *serialization.ByteBuf) (*TestMultiRowType3, error) {
    v := &TestMultiRowType3{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
