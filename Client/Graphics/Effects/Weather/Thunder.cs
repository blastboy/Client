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


using System;
using System.Collections.Generic;
using System.Text;

using Client.Logic.Graphics.Effects.Overlays;
using SdlDotNet.Graphics;
using System.Drawing;

namespace Client.Logic.Graphics.Effects.Weather
{
	/// <summary>
	/// Description of Thunder.
	/// </summary>
	class Thunder : IWeather
	{
		
		#region Fields

        bool disposed;
        List<Raindrop> raindrops = new List<Raindrop>();
        

        #endregion Fields

        #region Constructors

        public Thunder() {
            disposed = false;
            for (int i = 0; i < 100; i++) {
                raindrops.Add(new Raindrop());
            }
            
        }

        #endregion Constructors

        #region Properties

        public bool Disposed {
            get { return disposed; }
        }

        #endregion Properties

        #region Methods

        public void FreeResources() {
            disposed = true;
            for (int i = raindrops.Count - 1; i >= 0; i--) {
                raindrops[i].Dispose();
                raindrops.RemoveAt(i);
            }
        }

        public void Render(Renderers.RendererDestinationData destData, int tick) {
            for (int i = 0; i < raindrops.Count; i++) {
                raindrops[i].UpdateLocation(2);
                destData.Blit(raindrops[i], new Point(raindrops[i].X, raindrops[i].Y));
            }
        }

        #endregion Methods
		
		public Enums.Weather ID {
            get { return Enums.Weather.Thunder; }
        }
	}
}
