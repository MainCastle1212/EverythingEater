using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    EatableObjSO PlayerSO;
    [SerializeField]
    CinemachineTargetGroup targetGroup;
    [SerializeField]
    float DistancePlayerScale;
    [SerializeField]
    float Distance;

    private float BaffaDistancePlayerScale;
    private void Start()
    {
        BaffaDistancePlayerScale = DistancePlayerScale;
    }
    void Update()
    {
        PlayerSO.Size = Player.BiggestSize;
        AwayCamera();
    }
    public void AwayCamera()
    {
        var targets = targetGroup.m_Targets;
        if (Player.BiggestSize > DistancePlayerScale)
        {
            targets[0].radius += Distance;
            DistancePlayerScale += BaffaDistancePlayerScale;
        }
    }
}
