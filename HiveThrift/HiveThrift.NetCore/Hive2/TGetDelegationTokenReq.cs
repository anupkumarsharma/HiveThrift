/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Transport;

namespace Hive2
{
#if !SILVERLIGHT

#endif

    public partial class TGetDelegationTokenReq : TBase
    {
        public TSessionHandle SessionHandle { get; set; }

        public string Owner { get; set; }

        public string Renewer { get; set; }

        public TGetDelegationTokenReq()
        {
        }

        public TGetDelegationTokenReq(TSessionHandle sessionHandle, string owner, string renewer) : this()
        {
            this.SessionHandle = sessionHandle;
            this.Owner = owner;
            this.Renewer = renewer;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_sessionHandle = false;
            bool isset_owner = false;
            bool isset_renewer = false;
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
                        if (field.Type == TType.Struct)
                        {
                            SessionHandle = new TSessionHandle();
                            SessionHandle.Read(iprot);
                            isset_sessionHandle = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.String)
                        {
                            Owner = iprot.ReadString();
                            isset_owner = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 3:
                        if (field.Type == TType.String)
                        {
                            Renewer = iprot.ReadString();
                            isset_renewer = true;
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
            if (!isset_sessionHandle)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_owner)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_renewer)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("TGetDelegationTokenReq");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "sessionHandle";
            field.Type = TType.Struct;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            SessionHandle.Write(oprot);
            oprot.WriteFieldEnd();
            field.Name = "owner";
            field.Type = TType.String;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Owner);
            oprot.WriteFieldEnd();
            field.Name = "renewer";
            field.Type = TType.String;
            field.ID = 3;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Renewer);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("TGetDelegationTokenReq(");
            sb.Append("SessionHandle: ");
            sb.Append(SessionHandle == null ? "<null>" : SessionHandle.ToString());
            sb.Append(",Owner: ");
            sb.Append(Owner);
            sb.Append(",Renewer: ");
            sb.Append(Renewer);
            sb.Append(")");
            return sb.ToString();
        }
    }
}