﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind15 : InfluenceKind
    {
        private float rate;

        public override void ApplyInfluenceKind(Person person)
        {
            person.RateIncrementOfEnduranceAbility += this.rate;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.rate = float.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Person person)
        {
            person.RateIncrementOfEnduranceAbility -= this.rate;
        }
    }
}

