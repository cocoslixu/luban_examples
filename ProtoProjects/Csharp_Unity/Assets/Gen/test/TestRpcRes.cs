//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;

namespace proto.test
{

    public  sealed class TestRpcRes :  Bright.Serialization.BeanBase 
    {
        public TestRpcRes()
        {
        }

        public TestRpcRes(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializeTestRpcRes(ByteBuf _buf, TestRpcRes x)
        {
            x.Serialize(_buf);
        }

        public static TestRpcRes DeserializeTestRpcRes(ByteBuf _buf)
        {
            var x = new test.TestRpcRes();
            x.Deserialize(_buf);
            return x;
        }

         public int X;

         public int Y;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteInt(X);
            _buf.WriteInt(Y);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            X = _buf.ReadInt();
            Y = _buf.ReadInt();
        }

        public override string ToString()
        {
            return "test.TestRpcRes{ "
            + "X:" + X + ","
            + "Y:" + Y + ","
            + "}";
        }
    }

}
