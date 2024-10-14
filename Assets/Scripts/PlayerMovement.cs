using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A e D
        float moveZ = Input.GetAxis("Vertical");   // W e S

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}