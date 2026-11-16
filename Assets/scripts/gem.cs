using UnityEngine;

public class gem  : MonoBehaviour
{
    private int gemValue = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (CointManager.instance != null)
            {
                CointManager.instance.AddCoins(gemValue);
            }
            Destroy(gameObject);
        }
    }
}