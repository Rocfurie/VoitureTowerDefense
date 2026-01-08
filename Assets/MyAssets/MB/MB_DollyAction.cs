
using Unity.Cinemachine;
using UnityEngine;

public class DollyLoop : MonoBehaviour
{
    public CinemachineSplineCart dolly; 
    public float speed = 1f;

    void Update()
    {
        if (dolly == null) return;

        // Avance sur le rail
        dolly.SplinePosition += speed * Time.deltaTime;

        // Boucle infinie
        if (dolly.SplinePosition > 1f)
            dolly.SplinePosition -= 1f;
    }
}