// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputAppEvent : TLObject 
	{
		public Double Time { get; set; }
		public String Type { get; set; }
		public Int64 Peer { get; set; }
		public String Data { get; set; }

		public TLInputAppEvent() { }
		public TLInputAppEvent(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputAppEvent; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Time = from.ReadDouble();
			Type = from.ReadString();
			Peer = from.ReadInt64();
			Data = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x770656A8);
			to.Write(Time);
			to.Write(Type);
			to.Write(Peer);
			to.Write(Data);
			if (cache) WriteToCache(to);
		}
	}
}