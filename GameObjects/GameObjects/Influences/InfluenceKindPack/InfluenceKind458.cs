﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind458 : InfluenceKind
    {
        private int increment = 0;

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.IncrementOfAttractDay = this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.IncrementOfAttractDay = 0;
        }
    }
}

