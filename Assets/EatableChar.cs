using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatableChar : EatableObjContoroller
{
    BoxCollider2D m_Collider;
    protected override void Start()
    {
        m_Collider = GetComponent<BoxCollider2D>();
    }
    public override float ObjSize => m_Collider.bounds.size.x * m_Collider.bounds.size.y;
    protected override void DestroyedGameObject()
    {
        var parentText = transform.parent.gameObject;
        Destroy(parentText);

        base.DestroyedGameObject();
    }
}
