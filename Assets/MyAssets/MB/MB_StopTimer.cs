using UnityEngine;
using TMPro;

public class MB_StopTimer : MonoBehaviour
{
    public MB_Timer MB_Timer;
    public TextMeshProUGUI TimerValeur;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Trigger entered by: " + col.gameObject.name);
            if (MB_Timer.timerActive)
            {
                if (col.gameObject.tag == "Player")
                {

                    MB_Timer.timerActive = false;
                    TimerValeur.text = "Temps : " + MB_Timer.timer.ToString("F2") + "s";
                    MB_Timer.timer = 0f;
                }
            }
        }
    }

}
