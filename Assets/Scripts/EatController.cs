using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var eatObj = collision.gameObject;
        Debug.Log(eatObj.name);
        //TODO 自分より小さいならばのif文
        var e = eatObj.GetComponent<EatableObjContoroller>();
        if (e == null) return;
        e.Eaten();
    }
}
