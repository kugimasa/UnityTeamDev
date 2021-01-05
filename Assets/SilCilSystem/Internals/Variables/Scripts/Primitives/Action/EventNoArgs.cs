﻿using System;
using SilCilSystem.Editors;
using SilCilSystem.Variables;

namespace SilCilSystem.Internals
{
    [Variable("Changed")]
    internal class EventNoArgs : GameEvent
    {
        private event Action m_event = default;

        public override void Publish()
        {
            m_event?.Invoke();
        }

        public override IDisposable Subscribe(Action action)
        {
            m_event += action;
            return DelegateDispose.Create(() => m_event -= action);
        }
    }
}