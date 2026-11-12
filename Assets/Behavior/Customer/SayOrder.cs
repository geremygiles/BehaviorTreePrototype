using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/SayOrder")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "SayOrder", message: "[Agent] says order", category: "Events", id: "816b801782bc79468a6a536b7a6254fd")]
public sealed partial class SayOrder : EventChannel<GameObject> { }

