﻿using System;
using System.Collections.Generic;
using UnityEngine;
using SilCilSystem.Variables;
using SilCilSystem.Variables.Base;

namespace SilCilSystem.Internals
{
    internal class EventColorListener : GameEventColorListener
    {
        [SerializeField, HideInInspector] private GameEventColor m_event = default;

        public override IDisposable Subscribe(Action<Color> action) => m_event?.Subscribe(action);

        public override void GetAssetName(ref string name) => name = $"{name}_Listener";
        public override void OnAttached(IEnumerable<VariableAsset> variables)
        {
            foreach (var variable in variables)
            {
                if (!(variable is GameEventColor onChanged)) continue;
                m_event = onChanged;
                return;
            }
        }
    }
}