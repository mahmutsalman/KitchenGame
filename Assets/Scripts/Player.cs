using UnityEngine;

public class Player : MonoBehaviour
{
    public float stepSize = 1f;

    private void Update()
    {
        Vector2 moveDir = new Vector2(0, 0);

        if (Input.GetKeyDown(KeyCode.W)) moveDir.y = +1;
        if (Input.GetKeyDown(KeyCode.S)) moveDir.y = -1;
        if (Input.GetKeyDown(KeyCode.A)) moveDir.x = -1;
        if (Input.GetKeyDown(KeyCode.D)) moveDir.x = +1;

        Vector3 moveDir3 = new Vector3(moveDir.x, 0f, moveDir.y);
        transform.position += moveDir3 * stepSize;

        if (moveDir3 != Vector3.zero) {
            float rotateSpeed = 10f;
            transform.forward = Vector3.Slerp(transform.forward, moveDir3, Time.deltaTime * rotateSpeed);
        }

        Debug.Log(moveDir3);
    }
    
}
