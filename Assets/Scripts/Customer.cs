using System.Collections;
using TMPro;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private const float SPEAKING_SPEED = 0.1f;
    FoodOrder order;
    [SerializeField] TextMeshProUGUI speakingText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateOrder();
        StartCoroutine(Speak(order.OrderString));
    }

    private void GenerateOrder()
    {
        order = new FoodOrder();
    }

    public IEnumerator Speak(string line)
    {
        speakingText.text = string.Empty;
        string[] words = line.Split(' ');
        
        foreach (string word in words)
        {
            speakingText.text += word + " ";
            yield return new WaitForSeconds(SPEAKING_SPEED);
        }
    }
}
