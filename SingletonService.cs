using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Singleton
{
	[ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
	public class SingletonService : ISingletonService
	{
		int _numberOfRequests = 0;

		public SingletonResponse GetData()
		{
			SingletonResponse response = new SingletonResponse
			{
				DateTimeStamp = DateTime.Now,
				NumberOfRequests = _numberOfRequests++
			};

			return response;
		}
	}
}
