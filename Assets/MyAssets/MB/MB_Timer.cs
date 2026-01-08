using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class MB_Timer : MonoBehaviour
{
    public bool timerActive = false;
    public float timer = 0f;
    public TextMeshProUGUI TimerValeur;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timer += Time.deltaTime;
            TimerValeur.text = "Temps : " + timer.ToString("F2") + "s";
        }



    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Trigger entered by: " + col.gameObject.name);
            if (!timerActive)
                if (col.gameObject.tag == "Player")
                {
                    timerActive = true;
                }
        }
    }
}
