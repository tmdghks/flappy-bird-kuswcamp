using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // Move pipe leftward
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }
}
