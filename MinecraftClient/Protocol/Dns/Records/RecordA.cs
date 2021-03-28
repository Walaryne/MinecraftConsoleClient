using System.Net;
/*
 3.4.1. A RDATA format

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    |                    ADDRESS                    |
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

ADDRESS         A 32 bit Internet address.

Hosts that have multiple Internet addresses will have multiple A
records.
 * 
 */
namespace Heijden.DNS
{
	public class RecordA : Record
	{
		public IPAddress Address;

		public RecordA(RecordReader rr)
		{
			IPAddress.TryParse(string.Format("{0}.{1}.{2}.{3}",
			                                 rr.ReadByte(),
			                                 rr.ReadByte(),
			                                 rr.ReadByte(),
			                                 rr.ReadByte()), out Address);
		}

		public override string ToString()
		{
			return Address.ToString();
		}

	}
}
