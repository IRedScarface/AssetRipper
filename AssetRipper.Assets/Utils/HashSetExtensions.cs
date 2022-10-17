﻿namespace AssetRipper.Assets.Utils;

internal static class HashSetExtensions
{
	public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> values)
	{
		foreach (T value in values)
		{
			set.Add(value);
		}
	}
}
