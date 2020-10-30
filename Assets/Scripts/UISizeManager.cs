using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISizeManager : MonoBehaviour
{
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private RectTransform PlayerUI;
    [SerializeField]
    private RectTransform TargetUI;
    [SerializeField]
    private Text Size;
    [SerializeField]
    private float GoalSize = 30;

    private float PlayerScale;
    private float BaffaPlayerSize;

    private float Ratio;
    private void Awake()
    {
        PlayerScale = Player.localScale.x;

        Ratio = (TargetUI.rect.width - PlayerUI.rect.width) / GoalSize;
    }
    private void Update()
    {
        BaffaPlayerSize = PlayerScale;

        var diff = Player.localScale.x - BaffaPlayerSize;
        PlayerUI.sizeDelta += new Vector2(Ratio * diff, Ratio * diff);

        Debug.Log(diff);

        var sizeAfterDecimal = GetAfterDecimalPoint(PlayerScale) * 10;
        Size.text = $"{PlayerScale}㍍{sizeAfterDecimal:0}㌢";

        PlayerScale = Player.localScale.x;
    }
    /// <summary>
    /// 小数点以下を返すメソッド
    /// </summary>
    /// <param name="num">
    /// </param>
    /// <returns></returns>
    private float GetAfterDecimalPoint(float num)
    {
        return num % 1;
    }
}
