using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 0.5f;

    private Rigidbody rb;
    private float yaw;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        yaw += mouseX;
        transform.rotation = Quaternion.Euler(0f, yaw, 0f);
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direction = transform.forward * v + transform.right * h;
        Vector3 velocity = direction.normalized * moveSpeed;

        Vector3 newPos = rb.position + velocity * Time.fixedDeltaTime;
        rb.MovePosition(newPos);
    }
}
