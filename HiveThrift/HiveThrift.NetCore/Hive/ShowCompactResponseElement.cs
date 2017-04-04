/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Text;
using Thrift.Protocol;

namespace Hive
{
#if !SILVERLIGHT

    
#endif
    public partial class ShowCompactResponseElement : TBase
    {
        public string Dbname { get; set; }

        public string Tablename { get; set; }

        public string Partitionname { get; set; }

        /// <summary>
        ///
        /// <seealso cref="CompactionType"/>
        /// </summary>
        public CompactionType Type { get; set; }

        public string State { get; set; }

        public string Workerid { get; set; }

        public long Start { get; set; }

        public string RunAs { get; set; }

        public ShowCompactResponseElement()
        {
        }

        public ShowCompactResponseElement(string dbname, string tablename, string partitionname, CompactionType type, string state, string workerid, long start, string runAs)
            : this()
        {
            this.Dbname = dbname;
            this.Tablename = tablename;
            this.Partitionname = partitionname;
            this.Type = type;
            this.State = state;
            this.Workerid = workerid;
            this.Start = start;
            this.RunAs = runAs;
        }

        public void Read(TProtocol iprot)
        {
            bool isset_dbname = false;
            bool isset_tablename = false;
            bool isset_partitionname = false;
            bool isset_type = false;
            bool isset_state = false;
            bool isset_workerid = false;
            bool isset_start = false;
            bool isset_runAs = false;
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
                            Dbname = iprot.ReadString();
                            isset_dbname = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 2:
                        if (field.Type == TType.String)
                        {
                            Tablename = iprot.ReadString();
                            isset_tablename = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 3:
                        if (field.Type == TType.String)
                        {
                            Partitionname = iprot.ReadString();
                            isset_partitionname = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 4:
                        if (field.Type == TType.I32)
                        {
                            Type = (CompactionType)iprot.ReadI32();
                            isset_type = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 5:
                        if (field.Type == TType.String)
                        {
                            State = iprot.ReadString();
                            isset_state = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 6:
                        if (field.Type == TType.String)
                        {
                            Workerid = iprot.ReadString();
                            isset_workerid = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 7:
                        if (field.Type == TType.I64)
                        {
                            Start = iprot.ReadI64();
                            isset_start = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    case 8:
                        if (field.Type == TType.String)
                        {
                            RunAs = iprot.ReadString();
                            isset_runAs = true;
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
            if (!isset_dbname)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_tablename)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_partitionname)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_type)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_state)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_workerid)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_start)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_runAs)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("ShowCompactResponseElement");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "dbname";
            field.Type = TType.String;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Dbname);
            oprot.WriteFieldEnd();
            field.Name = "tablename";
            field.Type = TType.String;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Tablename);
            oprot.WriteFieldEnd();
            field.Name = "partitionname";
            field.Type = TType.String;
            field.ID = 3;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Partitionname);
            oprot.WriteFieldEnd();
            field.Name = "type";
            field.Type = TType.I32;
            field.ID = 4;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32((int)Type);
            oprot.WriteFieldEnd();
            field.Name = "state";
            field.Type = TType.String;
            field.ID = 5;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(State);
            oprot.WriteFieldEnd();
            field.Name = "workerid";
            field.Type = TType.String;
            field.ID = 6;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(Workerid);
            oprot.WriteFieldEnd();
            field.Name = "start";
            field.Type = TType.I64;
            field.ID = 7;
            oprot.WriteFieldBegin(field);
            oprot.WriteI64(Start);
            oprot.WriteFieldEnd();
            field.Name = "runAs";
            field.Type = TType.String;
            field.ID = 8;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(RunAs);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("ShowCompactResponseElement(");
            sb.Append("Dbname: ");
            sb.Append(Dbname);
            sb.Append(",Tablename: ");
            sb.Append(Tablename);
            sb.Append(",Partitionname: ");
            sb.Append(Partitionname);
            sb.Append(",Type: ");
            sb.Append(Type);
            sb.Append(",State: ");
            sb.Append(State);
            sb.Append(",Workerid: ");
            sb.Append(Workerid);
            sb.Append(",Start: ");
            sb.Append(Start);
            sb.Append(",RunAs: ");
            sb.Append(RunAs);
            sb.Append(")");
            return sb.ToString();
        }
    }
}