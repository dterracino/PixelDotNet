﻿using System;

namespace PaintDotNet
{
    public sealed partial class UserBlendOps
	{
		public class DarkenBlendOp : UserBlendOp
		{
			public override ColorBgra Apply(ColorBgra lhs, ColorBgra rhs)
			{
				throw new NotImplementedException();
			}
		}
	}
}