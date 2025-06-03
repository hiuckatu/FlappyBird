using System;
using UnityEngine;

public class BlockBottom : MonoBehaviour
{
    public float BlockMoveBottom;

    void Start()
    {
        UnityEngine.Random.InitState(DateTime.Now.Millisecond);
        BlockMoveBottom = UnityEngine.Random.Range(0.0f, 1.8f);
        transform.Translate(0, BlockMoveBottom, 0);
    }

    void Update()
    {
        
    }
}
