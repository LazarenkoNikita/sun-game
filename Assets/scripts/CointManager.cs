using UnityEngine;
using TMPro;

public class CointManager : MonoBehaviour
{
    public static CointManager instance;
    public TextMeshProUGUI gemText;
    private int totalGem = 0;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void AddCoins(int amount)
    {
        totalGem = totalGem + amount;
        UpdateUI();
    }
    private void UpdateUI()
    {
        if (gemText != null)
        {
            gemText.text = totalGem + "";
        }
    }

}  
        

           