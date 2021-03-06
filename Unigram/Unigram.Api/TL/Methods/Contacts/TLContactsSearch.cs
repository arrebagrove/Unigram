// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.search
	/// </summary>
	public partial class TLContactsSearch : TLObject
	{
		public String Q { get; set; }
		public Int32 Limit { get; set; }

		public TLContactsSearch() { }
		public TLContactsSearch(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ContactsSearch; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Q = from.ReadString();
			Limit = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x11F812D8);
			to.Write(Q);
			to.Write(Limit);
			if (cache) WriteToCache(to);
		}
	}
}