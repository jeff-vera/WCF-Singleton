using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Singleton
{
	[ServiceContract]
	public interface ISingletonService
	{
		[OperationContract]
		string GetData(int value);
	}

}
