using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using Unity.VisualScripting;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Line Up", story: "Get [front] from [Spawner]", category: "Action", id: "d1cef55043198d6453b81399303187d4")]
public partial class LineUpAction : Action
{
    [SerializeReference] public BlackboardVariable<Transform> Front;
    [SerializeReference] public BlackboardVariable<CustomerSpawner> Spawner;

    protected override Status OnStart()
    {
        Transform customerInFront = Spawner.Value.LastCustomer;
        Vector3 behind = new Vector3(customerInFront.position.x, customerInFront.position.y, customerInFront.position.z - 2f);
        Front.Value = Spawner.Value.LastCustomer;
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

