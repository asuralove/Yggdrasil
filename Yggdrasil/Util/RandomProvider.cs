﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Threading;

namespace Yggdrasil.Util
{
	/// <summary>
	/// Thread-safe provider for "Random" instances.
	/// </summary>
	public static class RandomProvider
	{
		private static readonly Random _seed = new Random();

		[ThreadStatic]
		private static Random _random;

		/// <summary>
		/// Returns an instance of Random for the calling thread.
		/// </summary>
		/// <returns></returns>
		public static Random Get()
		{
			if (_random != null)
				return _random;

			int seed;
			lock (_seed)
				seed = _seed.Next();

			return (_random = new Random(seed));
		}
	}
}
