using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Talker : MonoBehaviour
{
    private const float SPEAKING_SPEED = 0.1f;

    private const float WAIT_TIME = .25f;

    [SerializeField] GameObject textBox;

    [SerializeField] TextMeshProUGUI speakingText;
    
    public bool Done
    {
        get
        {
            return (started && !speaking);
        }
    }

    bool started = false;
    bool speaking = false;

    private void Start()
    {
        textBox.SetActive(false);
    }

    public void StartSaying(string line)
    {
        speakingText.text = string.Empty;
        textBox.SetActive(true);
        started = speaking = true;
        StartCoroutine(Say(line));
    }

    private IEnumerator Say(string line)
    {
        string[] words = line.Split(' ');

        foreach (string word in words)
        {
            speakingText.text += word + " ";
            yield return new WaitForSeconds(SPEAKING_SPEED);
        }

        yield return new WaitForSeconds(WAIT_TIME * words.Length);

        textBox.SetActive(false);
        speaking = false;
    }
}
