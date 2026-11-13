using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Lerp Rotate", story: "[Agent] turns to [YRotation] degrees", category: "Action", id: "b354faecf2c51bb555f4811d383e40df")]
public partial class LerpRotateAction : Action
{
    [SerializeReference] public BlackboardVariable<Transform> Agent;
    [SerializeReference] public BlackboardVariable<int> YRotation;
    Vector3 targetRotation = Vector3.zero;

    float lerp = 0f;
    float lerpSpeed = 1f;
    protected override Status OnStart()
    {
        targetRotation.y = YRotation.Value;
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        lerp += Time.deltaTime * lerpSpeed;

        Quaternion newRotation;

        if (YRotation < Agent.Value.rotation.y) // Ensures the larger value is the starting lerp
        {
            newRotation = Quaternion.Lerp(Agent.Value.rotation, Quaternion.Euler(targetRotation), lerp);
        }
        else
        {
            newRotation = Quaternion.Lerp(Quaternion.Euler(targetRotation), Agent.Value.rotation, lerp);
        }

        Agent.Value.rotation = newRotation;

        if (lerp >= 1) return Status.Success;
        else return Status.Running;
    }

    protected override void OnEnd()
    {
    }
}

