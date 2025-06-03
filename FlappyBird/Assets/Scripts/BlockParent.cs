using System;
using Unity.VisualScripting;
using UnityEngine;

public class BlockParent : MonoBehaviour
{

    public float BlockverMove;
    void Start()
    {
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
        BlockverMove = UnityEngine.Random.Range(-2.0f, 2.0f);
        transform.Translate(0, BlockverMove, 0);
    }

    private void Update()
    {
        GetChildren(this.gameObject);
    }

    void GetChildren(GameObject parent)
    {
        Transform children = parent.GetComponentInChildren<Transform>();
        //éqóvëfÇ™Ç¢Ç»ÇØÇÍÇŒèIóπ
        if (children.childCount == 0)
        {
            Destroy(gameObject);
            return;
        }
    }
}