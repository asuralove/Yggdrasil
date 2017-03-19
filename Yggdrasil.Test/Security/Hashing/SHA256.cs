﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Text;
using Xunit;
using Yggdrasil.Security.Hashing;

namespace Yggdrasil.Test.Security.Hashing
{
	public class SHA256Tests
	{
		[Fact]
		public void Encode()
		{
			Assert.Equal("03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4", SHA256.Encode("1234"));
			Assert.Equal(new byte[] { 0x03, 0xAC, 0x67, 0x42, 0x16, 0xF3, 0xE1, 0x5C, 0x76, 0x1E, 0xE1, 0xA5, 0xE2, 0x55, 0xF0, 0x67, 0x95, 0x36, 0x23, 0xC8, 0xB3, 0x88, 0xB4, 0x45, 0x9E, 0x13, 0xF9, 0x78, 0xD7, 0xC8, 0x46, 0xF4 },
				SHA256.Encode(Encoding.UTF8.GetBytes("1234")));

			Assert.Equal("DFFD6021BB2BD5B0AF676290809EC3A53191DD81C7F70A4B28688A362182986F", SHA256.Encode("Hello, World!"));
			Assert.Equal(new byte[] { 0xDF, 0xFD, 0x60, 0x21, 0xBB, 0x2B, 0xD5, 0xB0, 0xAF, 0x67, 0x62, 0x90, 0x80, 0x9E, 0xC3, 0xA5, 0x31, 0x91, 0xDD, 0x81, 0xC7, 0xF7, 0x0A, 0x4B, 0x28, 0x68, 0x8A, 0x36, 0x21, 0x82, 0x98, 0x6F },
				SHA256.Encode(Encoding.UTF8.GetBytes("Hello, World!")));
		}
	}
}