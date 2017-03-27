using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChatter
{
	public class Config
	{
		#region settings

		private static Config _config;

		[DefaultValue(2000)]
		public int IntervalMillisends = 2000;




		#endregion
	}
}
