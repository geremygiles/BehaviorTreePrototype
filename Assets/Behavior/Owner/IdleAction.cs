using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Idle", story: "Idle with [Animator]", category: "Action", id: "71a4d86a3b33da8b2f6642661bd29340")]
public partial class IdleAction : Action
{
    [SerializeReference] public BlackboardVariable<Animator> Animator;
    protected override Status OnStart()
    {
        Animator.Value.SetTrigger("Idle");
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

