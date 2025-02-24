using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool passed = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !passed)
        {
            Debug.Log("Score!");
            GameManager.Instance.AddScore(1);
            passed = true;
        }
    }
}
