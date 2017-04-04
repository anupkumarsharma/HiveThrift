/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Text;
using Thrift;
using Thrift.Protocol;

namespace Hive
{
#if !SILVERLIGHT

    
#endif
    public partial class HiveServerException : TException, TBase
    {
        private string _message;
        private int _errorCode;
        private string _SQLState;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                __isset.message = true;
                this._message = value;
            }
        }

        public int ErrorCode
        {
            get
            {
                return _errorCode;
            }
            set
            {
                __isset.errorCode = true;
                this._errorCode = value;
            }
        }

        public string SQLState
        {
            get
            {
                return _SQLState;
            }
            set
            {
                __isset.SQLState = true;
                this._SQLState = value;
            }
        }

        public Isset __isset;
#if !SILVERLIGHT

        
#endif
        public struct Isset
        {
            public bool message;
            public bool errorCode;
            public bool SQLState;
        }

        public HiveServerException()
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
                        if (field.Type == TType.String)
                        {
                            Message = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.I32)
                        {
                            ErrorCode = iprot.ReadI32();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 3:
                        if (field.Type == TType.String)
                        {
                            SQLState = iprot.ReadString();
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
            TStruct struc = new TStruct("HiveServerException");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (Message != null && __isset.message)
            {
                field.Name = "message";
                field.Type = TType.String;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(Message);
                oprot.WriteFieldEnd();
            }
            if (__isset.errorCode)
            {
                field.Name = "errorCode";
                field.Type = TType.I32;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteI32(ErrorCode);
                oprot.WriteFieldEnd();
            }
            if (SQLState != null && __isset.SQLState)
            {
                field.Name = "SQLState";
                field.Type = TType.String;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(SQLState);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("HiveServerException(");
            sb.Append("Message: ");
            sb.Append(Message);
            sb.Append(",ErrorCode: ");
            sb.Append(ErrorCode);
            sb.Append(",SQLState: ");
            sb.Append(SQLState);
            sb.Append(")");
            return sb.ToString();
        }
    }
}