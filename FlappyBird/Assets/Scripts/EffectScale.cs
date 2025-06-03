using UnityEngine;
using static Unity.Collections.AllocatorManager;
using UnityEngine.UIElements;

public class EffectScale : MonoBehaviour

{
    public GameObject _deatheffect;

    void Start()
    {
        Player.Instance.SetEffectScale(this);
    }

    public void PlayerDeath()
    {
        Vector3 position = transform.position;
        GameObject effect = Instantiate(_deatheffect, position, Quaternion.identity);
    }
}
