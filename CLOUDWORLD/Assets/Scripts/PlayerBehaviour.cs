using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;

    [SerializeField] Rigidbody2D rb;

    private Weapon weapon;

    Vector2 movement;

    // Player Attack
    private GameObject _attackArea = default;

    private bool _attacking = false;

    private float _timeToAttack = 0.25f;
    private float _timer = 0f;

    void Start()
    {
        _attackArea = transform.GetChild(0).gameObject;
        weapon = GetComponentInChildren<Weapon>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            weapon.Attack();
        }

        if (_attacking)
        {
            _timer += Time.deltaTime;

            if (_timer >= _timeToAttack)
            {
                _timer = 0;
                _attacking = false;
                _attackArea.SetActive(_attacking);
            }
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
        CheckFlip();
    }

    void CheckFlip()
    {
        bool movingLeft = movement.x < 0;
        bool movingRight = movement.x > 0;

        if (movingLeft)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y);
        }

         if (movingRight)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y);
        }
    }

    void Attack()
    {
        _attacking = true;
        _attackArea.SetActive(_attacking);
    }
}
