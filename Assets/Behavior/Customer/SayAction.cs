using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using TMPro;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Say", story: "[Agent] says [line]", category: "Action", id: "a3a2059297656281101e70c8c39e0e69")]
public partial class SayAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<string> Line;
    private Talker talker;
    protected override Status OnStart()
    {
        talker = Agent.Value.GetComponent<Talker>();
        talker.StartSaying(Line);

        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if (talker.Done) return Status.Success;
        else return Status.Running;
    }
}

