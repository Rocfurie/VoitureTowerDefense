using UnityEngine;

public class MB_DeplacementPolicier : MonoBehaviour
{
    public Transform Joueur;
    private UnityEngine.AI.NavMeshAgent agent ;
    public PrometeoCarController joueurScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Joueur.position);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            joueurScript.maxSpeed = 0;
        }
    }
}
