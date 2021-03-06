/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;

namespace Hive
{
#if !SILVERLIGHT

    [Serializable]
#endif
    public partial class PrivilegeBag : TBase
    {
        private List<HiveObjectPrivilege> _privileges;

        public List<HiveObjectPrivilege> Privileges
        {
            get
            {
                return _privileges;
            }
            set
            {
                __isset.privileges = true;
                this._privileges = value;
            }
        }

        public Isset __isset;
#if !SILVERLIGHT

        [Serializable]
#endif
        public struct Isset
        {
            public bool privileges;
        }

        public PrivilegeBag()
        {
        }

        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.List)
                        {
                            {
                                Privileges = new List<HiveObjectPrivilege>();
                                TList _list8 = iprot.ReadListBegin();
                                for (int _i9 = 0; _i9 < _list8.Count; ++_i9)
                                {
                                    HiveObjectPrivilege _elem10 = new HiveObjectPrivilege();
                                    _elem10 = new HiveObjectPrivilege();
                                    _elem10.Read(iprot);
                                    Privileges.Add(_elem10);
                                }
                                iprot.ReadListEnd();
                            }
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("PrivilegeBag");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (Privileges != null && __isset.privileges)
            {
                field.Name = "privileges";
                field.Type = TType.List;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                {
                    oprot.WriteListBegin(new TList(TType.Struct, Privileges.Count));
                    foreach (HiveObjectPrivilege _iter11 in Privileges)
                    {
                        _iter11.Write(oprot);
                    }
                    oprot.WriteListEnd();
                }
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("PrivilegeBag(");
            sb.Append("Privileges: ");
            sb.Append(Privileges);
            sb.Append(")");
            return sb.ToString();
        }
    }
}