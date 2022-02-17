﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.DataMiner.Net.Messages
{
	[Serializable]
	public class SetParameterMessage
	{
	}

	[Serializable]
	public enum SetParameterTableIndexPreference
	{
		Undefined,
		ByPrimaryKey,
		ByDisplayKey,
		PreferPrimaryKey,
		PreferDisplayKey
	}
}
