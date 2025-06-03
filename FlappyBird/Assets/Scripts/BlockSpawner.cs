using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject block;
    float _timer = 0;
    float _totaltime = 0;
    float delay = 0;
    public int totalsummon = 0;

    void Start()
    {

    }

    void Update()
    {
        _totaltime += Time.deltaTime;
        if(_totaltime >= 10f)
        {
            _totaltime = 0f;
            delay += 1.0f;
        }
        _timer -= Time.deltaTime;
        if (_timer < 0)
        {
            Vector3 position = transform.position;
            GameObject obj = Instantiate(block, position, Quaternion.identity);
            totalsummon += 1;
            _timer += 1 - (delay * 0.01f);
        }
    }
}