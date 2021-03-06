﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind3120 : InfluenceKind
    {
        private int increment = 0;

        public override void ApplyInfluenceKind(Architecture architecture)
        {
            architecture.CombativityOfRecruitment += this.increment - 50;
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

        public override void PurifyInfluenceKind(Architecture architecture)
        {
            architecture.CombativityOfRecruitment -= this.increment - 50;
        }

        public override double AIFacilityValue(Architecture a)
        {
            return (a.FrontLine ? (this.increment - 50) / 25.0 : 0.01) * (a.FrontLine ? 2 : 1) * (a.HostileLine ? 2 : 1) * (a.CriticalHostile ? 2 : 1);
        }
    }
}

