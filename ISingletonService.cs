using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Singleton
{
	[ServiceContract]
	public interface ISingletonService
	{
		[OperationContract]
		SingletonResponse GetData();
	}

}
