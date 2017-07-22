// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChatEditPhoto : TLMessageActionBase 
	{
		public TLPhotoBase Photo { get; set; }

		public TLMessageActionChatEditPhoto() { }
		public TLMessageActionChatEditPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChatEditPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			Photo = TLFactory.Read<TLPhotoBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Photo);
		}
	}
}