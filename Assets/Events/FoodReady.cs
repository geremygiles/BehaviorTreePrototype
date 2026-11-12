using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Food Ready")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Food Ready", message: "Food Ready", category: "Events", id: "483d9794488ad156390d50c826f9de23")]
public sealed partial class FoodReady : EventChannel { }

