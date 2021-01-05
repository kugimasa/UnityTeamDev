﻿using UnityEngine;
using SilCilSystem.Variables;
using SilCilSystem.Variables.Base;
using SilCilSystem.Editors;

namespace SilCilSystem.Internals
{
    [Variable("Readonly", Constants.ReadonlyMenuPath + "(Int)", typeof(VariableInt))]
    internal class ReadonlyIntValue : ReadonlyInt
    {
        [SerializeField] private VariableInt m_variable = default;

        public override int Value => m_variable;

        [OnAttached]
        private void OnAttached(VariableAsset parent)
        {
            m_variable = parent.GetSubVariable<VariableInt>();
        }
    }
}
