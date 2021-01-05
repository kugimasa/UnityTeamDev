﻿using UnityEngine;
using SilCilSystem.Variables;
using SilCilSystem.Variables.Base;
using SilCilSystem.Editors;

namespace SilCilSystem.Internals
{
    [Variable("Readonly", Constants.ReadonlyMenuPath + "(Quaternion)", typeof(VariableQuaternion))]
    internal class ReadonlyQuaternionValue : ReadonlyQuaternion
    {
        [SerializeField] private VariableQuaternion m_variable = default;

        public override Quaternion Value => m_variable;

        [OnAttached]
        private void OnAttached(VariableAsset parent)
        {
            m_variable = parent.GetSubVariable<VariableQuaternion>();
        }
    }
}
