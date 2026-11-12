using System.Collections;
using TMPro;
using Unity.Behavior;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private const float SPEAKING_SPEED = 0.1f;
    FoodOrder order;
    [SerializeField] GameObject textBox;
    [SerializeField] TextMeshProUGUI speakingText;
    [SerializeField] BehaviorGraphAgent behaviorGraphAgent;
    [SerializeField] SayOrder sayOrderChannel;
    public Transform Target;

    private void OnEnable()
    {
        if (sayOrderChannel != null)
        {
            sayOrderChannel.Event += StartOrder;
        }
    }

    private void OnDisable()
    {
        if (sayOrderChannel != null)
        {
            sayOrderChannel.Event -= StartOrder;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textBox.SetActive(false);

        GenerateOrder();
        //StartCoroutine(Speak(order.OrderString));

        behaviorGraphAgent.BlackboardReference.SetVariableValue<Transform>("Order Counter", Target);
        //navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.SetDestination(Target.position);
        //navMeshAgent.enabled = true;
    }

    private void GenerateOrder()
    {
        order = new FoodOrder();
    }

    private void StartOrder(GameObject _)
    {
        textBox.SetActive(true);
        StartCoroutine(Speak(order.OrderString));
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

        yield return new WaitForSeconds(2f);

        textBox.SetActive(false);
    }
}
