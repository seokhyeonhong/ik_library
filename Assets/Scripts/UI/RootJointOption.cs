using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootJointOption : JointOption
{
    new void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        string name = _jointNames[_dropdown.value];
        _character.GetComponent<IKSolver>().baseJoint = _joints[_jointNames.IndexOf(name)];
    }
}