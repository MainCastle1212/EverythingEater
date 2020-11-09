using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameSetting : ScriptableObject
{
    [Header("Level Name")]
    [SerializeField]
    string Name;
    [Header("Target Size")]
    public float GaolSize;
    [Header("Time Limit")]
    public int Time;
}
