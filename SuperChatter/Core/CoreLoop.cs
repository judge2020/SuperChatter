using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SuperChatter.Core
{
	class CoreLoop
	{
		private static CoreLoop _instance;

		public static CoreLoop Instance => _instance ?? (_instance = new CoreLoop());

		public DispatcherTimer Timer = new DispatcherTimer();

		public CoreLoop()
		{
			
		}
	}
}
