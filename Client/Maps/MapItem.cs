﻿// This file is part of Mystery Dungeon eXtended.

// Copyright (C) 2015 Pikablu, MDX Contributors, PMU Staff

// Mystery Dungeon eXtended is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Mystery Dungeon eXtended is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with Mystery Dungeon eXtended.  If not, see <http://www.gnu.org/licenses/>.


#region Header

/*
 * Created by SharpDevelop.
 * User: Pikachu
 * Date: 27/09/2009
 * Time: 11:47 AM
 *
 */

#endregion Header

namespace Client.Logic.Maps
{
	using System;

	/// <summary>
	/// Description of MapItem.
	/// </summary>
   [Serializable]
	internal class MapItem
	{
		#region Constructors

		public MapItem()
		{
		}

		#endregion Constructors

		#region Properties

		public bool Sticky
		{
			get; set;
		}

		public int Num
		{
			get; set;
		}

		public int Value
		{
			get; set;
		}

		public int X
		{
			get; set;
		}

		public int Y
		{
			get; set;
		}

		#endregion Properties
	}
}