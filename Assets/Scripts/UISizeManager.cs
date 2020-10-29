using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISizeManager : MonoBehaviour
{
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private Text Size;

    private float PlayerSize;
    private void Start()
    {
        PlayerSize = Player.localScale.x;
    }
    private void Update()
    {
        Size.text = $"{PlayerSize:00}㍍";
    }
}
