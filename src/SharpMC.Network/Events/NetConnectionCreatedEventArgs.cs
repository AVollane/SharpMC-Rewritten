﻿#region Imports

using System;

#endregion

namespace SharpMC.Network.Events
{
	public class NetConnectionCreatedEventArgs : EventArgs
	{
		public NetConnection Connection { get; }
		internal NetConnectionCreatedEventArgs(NetConnection connection)
		{
			Connection = connection;
		}
	}
}
