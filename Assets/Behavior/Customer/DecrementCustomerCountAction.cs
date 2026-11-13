using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Decrement Customer Count", story: "Decrement Customer Count in [Spawner]", category: "Action", id: "060ccbd18e94cd09a843faca67d9c4e8")]
public partial class DecrementCustomerCountAction : Action
{
    [SerializeReference] public BlackboardVariable<CustomerSpawner> Spawner;

    protected override Status OnStart()
    {
        Spawner.Value.DecrementCount();
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

