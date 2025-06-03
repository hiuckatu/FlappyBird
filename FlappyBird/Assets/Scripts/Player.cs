using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public BlockSpawner _blockspawner;

    [SerializeField] private float JUMP_VELOCITY = 349.3f;
    
    private Animator anim;
    private Rigidbody2D _rigidbody;
    private EffectScale effectScale;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.linearVelocity = Vector2.zero; 
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY));
            anim.SetTrigger("Jump");
        }
    }

    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        float y = transform.position.y;
        float vx = _rigidbody.linearVelocity.x;
        if (y > GetTop())
        {
            _rigidbody.linearVelocity = Vector2.zero;
            position.y = GetTop(); 
        }
        if (y < GetBottom())
        {
            _rigidbody.linearVelocity = Vector2.zero;
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY));
            position.y = GetBottom();
        }

        transform.position = position;
    }

    // 画面上を取得
    float GetTop()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        return max.y;
    }

    // 画面下を取得
    float GetBottom()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        return min.y;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        effectScale.PlayerDeath();

        Destroy(_blockspawner);
        Destroy(gameObject);
    }

    public void SetEffectScale(EffectScale effectScale)
    {
        this.effectScale = effectScale;
    }
}
