﻿using System;

namespace AssetRipper.Core.Attributes
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class PersistentIDAttribute : Attribute
	{
		public int ID { get; }

		public PersistentIDAttribute(int id)
		{
			this.ID = id;
		}
	}
}