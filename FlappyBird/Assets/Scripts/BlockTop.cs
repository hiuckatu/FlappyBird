using System;
using UnityEngine;

public class BlockTop : MonoBehaviour
{
    public float BlockMoveTop;
    void Start()
    {
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
        BlockMoveTop = UnityEngine.Random.Range(-1.8f, 0.0f);
        transform.Translate(0, BlockMoveTop, 0);
    }
    void Update()
    {
        
    }
}
