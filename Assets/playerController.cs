using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float rotSpeed = 360f;
    float speed = 3f;

    void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        var angle = transform.rotation.eulerAngles;
        angle.z -= h * rotSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(angle);

        transform.Translate(Vector2.up * v * speed * Time.deltaTime);
    }
}