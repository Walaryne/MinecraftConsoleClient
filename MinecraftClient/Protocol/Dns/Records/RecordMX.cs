using System;
namespace Heijden.DNS
{
	/*
	3.3.9. MX RDATA format

		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		|                  PREFERENCE                   |
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		/                   EXCHANGE                    /
		/                                               /
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

	where:

	PREFERENCE      A 16 bit integer which specifies the preference given to
					this RR among others at the same owner.  Lower values
					are preferred.

	EXCHANGE        A <domain-name> which specifies a host willing to act as
					a mail exchange for the owner name.

	MX records cause type A additional section processing for the host
	specified by EXCHANGE.  The use of MX RRs is explained in detail in
	[RFC-974].
	*/

	public class RecordMX : Record, IComparable
	{
		public ushort PREFERENCE;
		public string EXCHANGE;

		public RecordMX(RecordReader rr)
		{
			PREFERENCE = rr.ReadUInt16();
			EXCHANGE = rr.ReadDomainName();
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", PREFERENCE, EXCHANGE);
		}

		public int CompareTo(object objA)
		{
			var recordMX = objA as RecordMX;
			if (recordMX == null)
				return -1;
			if (PREFERENCE > recordMX.PREFERENCE)
				return 1;
			if (PREFERENCE < recordMX.PREFERENCE)
				return -1;
			return string.Compare(EXCHANGE, recordMX.EXCHANGE, true);
		}

	}
}
