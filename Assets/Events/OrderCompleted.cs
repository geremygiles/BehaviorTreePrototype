using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Order Completed")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Order Completed", message: "Order Completed", category: "Events", id: "325df29cfc6629f3eb23416b8a29ae48")]
public sealed partial class OrderCompleted : EventChannel { }

