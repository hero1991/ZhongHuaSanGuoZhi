﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind971 : ConditionKind
    {
        public override bool CheckConditionKind(Person person)
        {
            return !person.Sex;
        }
    }
}

