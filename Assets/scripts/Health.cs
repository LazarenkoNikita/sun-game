using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 3;
    public GameObject[] hearts;

    public void TakeDamage(float damage)
    {
        health = Mathf.Max(health - damage, 0);
        UpdateHearts();
    }

    public void AddHealth(float add)
    {
        health = Mathf.Min(health + add, hearts.Length);
        UpdateHearts();
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
            hearts[i].SetActive(i < health);
    }
}