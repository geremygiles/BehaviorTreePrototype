using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/WaitForOwner")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "WaitForOwner", message: "Owner Ready", category: "Events", id: "816b4d9667000fdc58e53a1c0a59f40d")]
public sealed partial class WaitForOwner : EventChannel { }

