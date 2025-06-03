using UnityEngine;

public class PrefabEffect : MonoBehaviour
{
    private float scale = 0f;
    private float maxScale = 2f;
    private float extendSpeed = 2f;
    void Start()
    {
        
    }


    void Update()
    {
        if (scale <= maxScale)
        {
            scale += extendSpeed * Time.deltaTime;
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
