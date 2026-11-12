using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using TMPro;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Say", story: "[Agent] says [line] in [TextBox]", category: "Action", id: "a3a2059297656281101e70c8c39e0e69")]
public partial class SayAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<string> Line;
    [SerializeReference] public BlackboardVariable<GameObject> TextBox;

    private TextMeshProUGUI text;
    protected override Status OnStart()
    {
        
        text = TextBox.Value.gameObject.GetComponent<TextMeshProUGUI>();
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

