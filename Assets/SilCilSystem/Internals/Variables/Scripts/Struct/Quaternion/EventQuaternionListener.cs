﻿using System;
using System.Collections.Generic;
using UnityEngine;
using SilCilSystem.Variables;
using SilCilSystem.Variables.Base;

namespace SilCilSystem.Internals
{
    internal class EventQuaternionListener : GameEventQuaternionListener
    {
        [SerializeField, HideInInspector] private GameEventQuaternion m_event = default;

        public override IDisposable Subscribe(Action<Quaternion> action) => m_event?.Subscribe(action);

        public override void GetAssetName(ref string name) => name = $"{name}_Listener";
        public override void OnAttached(IEnumerable<VariableAsset> variables)
        {
            foreach (var variable in variables)
            {
                if (!(variable is GameEventQuaternion onChanged)) continue;
                m_event = onChanged;
                return;
            }
        }
    }
}