using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Singleton
{
	public class SingletonService : ISingletonService
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}
	}
}
