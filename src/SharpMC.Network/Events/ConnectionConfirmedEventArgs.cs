﻿#region Imports

using System;

#endregion

namespace SharpMC.Network.Events
{
	public class ConnectionConfirmedEventArgs : EventArgs
	{
		public NetConnection Connection { get; }
		internal ConnectionConfirmedEventArgs(NetConnection connection)
		{
			Connection = connection;
		}
	}
}
