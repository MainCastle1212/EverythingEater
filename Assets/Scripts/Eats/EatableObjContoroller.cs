using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class EatableObjContoroller : MonoBehaviour, IEatable
{
    [SerializeField]
    EatableObjSO objSO;
    [SerializeField]
    UIEatenView UIEaten;

    private Renderer m_Renderer;
    protected virtual void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }
    /// <summary>
    /// 自分自身のサイズのプロパティ
    /// </summary>
    public virtual float ObjSize => m_Renderer.bounds.size.x * m_Renderer.bounds.size.y;

    private void OnDestroy()
    {
        DestroyedGameObject();
    }
    protected virtual void DestroyedGameObject()
    {
        UIEaten.View(objSO);
    }
}
