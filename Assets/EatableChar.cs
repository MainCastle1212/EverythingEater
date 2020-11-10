using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatableChar : EatableObjContoroller
{
    protected override void DestroyGameObjected()
    {
        var parentText = transform.parent.gameObject;
        Destroy(parentText);

        base.DestroyGameObjected();
    }
}
