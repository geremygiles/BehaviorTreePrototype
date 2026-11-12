using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Get Order", story: "[Agent] stores order in [OrderString]", category: "Action", id: "2a1ab96055ccc3cd5c83cfacb80ae55a")]
public partial class GetOrderAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<string> OrderString;

    Customer customer;

    protected override Status OnStart()
    {
        customer = Agent.Value.GetComponent<Customer>();

        OrderString.Value = customer.Order.OrderString;

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

