using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        Vector2 moveDir = new Vector2(0, 0);

        if (Input.GetKeyDown(KeyCode.W)) moveDir.y = +1;
        if (Input.GetKeyDown(KeyCode.S)) moveDir.y = -1;
        if (Input.GetKeyDown(KeyCode.A)) moveDir.x = -1;
        if (Input.GetKeyDown(KeyCode.D)) moveDir.x = +1;

        transform.position += (Vector3)moveDir;
        Debug.Log(transform.position);
    }
    
}
