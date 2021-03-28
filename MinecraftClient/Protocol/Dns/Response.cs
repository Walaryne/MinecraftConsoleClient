using System;
using System.Collections.Generic;
using System.Net;
namespace Heijden.DNS
{
	public class Response
	{
		/// <summary>
		/// List of Question records
		/// </summary>
		public List<Question> Questions;
		/// <summary>
		/// List of AnswerRR records
		/// </summary>
		public List<AnswerRR> Answers;
		/// <summary>
		/// List of AuthorityRR records
		/// </summary>
		public List<AuthorityRR> Authorities;
		/// <summary>
		/// List of AdditionalRR records
		/// </summary>
		public List<AdditionalRR> Additionals;

		public Header header;

		/// <summary>
		/// Error message, empty when no error
		/// </summary>
		public string Error;

		/// <summary>
		/// The Size of the message
		/// </summary>
		public int MessageSize;

		/// <summary>
		/// TimeStamp when cached
		/// </summary>
		public DateTime TimeStamp;

		/// <summary>
		/// Server which delivered this response
		/// </summary>
		public IPEndPoint Server;

		public Response()
		{
			Questions = new List<Question>();
			Answers = new List<AnswerRR>();
			Authorities = new List<AuthorityRR>();
			Additionals = new List<AdditionalRR>();

			Server = new IPEndPoint(0,0);
			Error = "";
			MessageSize = 0;
			TimeStamp = DateTime.Now;
			header = new Header();
		}

		public Response(IPEndPoint iPEndPoint, byte[] data)
		{
			Error = "";
			Server = iPEndPoint;
			TimeStamp = DateTime.Now;
			MessageSize = data.Length;
			var rr = new RecordReader(data);

			Questions = new List<Question>();
			Answers = new List<AnswerRR>();
			Authorities = new List<AuthorityRR>();
			Additionals = new List<AdditionalRR>();

			header = new Header(rr);

			for (var intI = 0; intI < header.QDCOUNT; intI++)
			{
				Questions.Add(new Question(rr));
			}

			for (var intI = 0; intI < header.ANCOUNT; intI++)
			{
				Answers.Add(new AnswerRR(rr));
			}

			for (var intI = 0; intI < header.NSCOUNT; intI++)
			{
				Authorities.Add(new AuthorityRR(rr));
			}
			for (var intI = 0; intI < header.ARCOUNT; intI++)
			{
				Additionals.Add(new AdditionalRR(rr));
			}
		}

		/// <summary>
		/// List of RecordMX in Response.Answers
		/// </summary>
		public RecordMX[] RecordsMX
		{
			get
			{
				var list = new List<RecordMX>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordMX;
					if(record!=null)
						list.Add(record);
				}
				list.Sort();
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordTXT in Response.Answers
		/// </summary>
		public RecordTXT[] RecordsTXT
		{
			get
			{
				var list = new List<RecordTXT>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordTXT;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordA in Response.Answers
		/// </summary>
		public RecordA[] RecordsA
		{
			get
			{
				var list = new List<RecordA>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordA;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordPTR in Response.Answers
		/// </summary>
		public RecordPTR[] RecordsPTR
		{
			get
			{
				var list = new List<RecordPTR>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordPTR;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordCNAME in Response.Answers
		/// </summary>
		public RecordCNAME[] RecordsCNAME
		{
			get
			{
				var list = new List<RecordCNAME>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordCNAME;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordAAAA in Response.Answers
		/// </summary>
		public RecordAAAA[] RecordsAAAA
		{
			get
			{
				var list = new List<RecordAAAA>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordAAAA;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordNS in Response.Answers
		/// </summary>
		public RecordNS[] RecordsNS
		{
			get
			{
				var list = new List<RecordNS>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordNS;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

		/// <summary>
		/// List of RecordSOA in Response.Answers
		/// </summary>
		public RecordSOA[] RecordsSOA
		{
			get
			{
				var list = new List<RecordSOA>();
				foreach (AnswerRR answerRR in Answers)
				{
					var record = answerRR.RECORD as RecordSOA;
					if (record != null)
						list.Add(record);
				}
				return list.ToArray();
			}
		}

        /// <summary>
        /// List of RecordSRV in Response.Answers
        /// </summary>
        public RecordSRV[] RecordsSRV
        {
            get
            {
                var list = new List<RecordSRV>();
                foreach (AnswerRR answerRR in Answers)
                {
                    var record = answerRR.RECORD as RecordSRV;
                    if (record != null)
                        list.Add(record);
                }
                return list.ToArray();
            }
        }

		public RR[] RecordsRR
		{
			get
			{
				var list = new List<RR>();
				foreach (RR rr in Answers)
				{
					list.Add(rr);
				}
				foreach (RR rr in Answers)
				{
					list.Add(rr);
				}
				foreach (RR rr in Authorities)
				{
					list.Add(rr);
				}
				foreach (RR rr in Additionals)
				{
					list.Add(rr);
				}
				return list.ToArray();
			}
		}
	}
}
