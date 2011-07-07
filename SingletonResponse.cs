using System;
using System.Runtime.Serialization;

namespace Singleton
{
	[DataContract]
	public class SingletonResponse
	{
		[DataMember]
		public DateTime DateTimeStamp { get; set; }

		[DataMember]
		public int NumberOfRequests { get; set; }
	}
}
