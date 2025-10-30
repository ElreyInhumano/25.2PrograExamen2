using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PlayerMoves();
    }

    void PlayerMoves()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);
        direction.Normalize();
        rb.linearVelocity = new Vector3(direction.x, 0, direction.y) * speed + Vector3.up * rb.linearVelocity.y;
    }
}
