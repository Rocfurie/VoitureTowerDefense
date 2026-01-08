using Unity.Cinemachine;
using UnityEngine;
using System.Collections;

public class MB_StartingCamera : MonoBehaviour
{
    public CinemachineCamera VCamSuivisJoueur;  
    public CinemachineCamera VCamRail;   

    public int EnCours = 2;
    public int EnStandBy = 1;

    // Appelle cette méthode pour switcher vers la caméra low
    public void SwitchVCamRail()
    {
        VCamRail.Priority = EnCours;
        VCamSuivisJoueur.Priority = EnStandBy;
    }

    // Optionnel : revenir à la caméra high
    public void SwitchVCamSuivisJoueur()
    {
        VCamRail.Priority = EnStandBy;
        VCamSuivisJoueur.Priority = EnCours;
    }

    void Start()
    {
        SwitchVCamRail();
        StartCoroutine(Attendre10s());
        
    }

    IEnumerator Attendre10s()
    {
        yield return new WaitForSeconds(10f);
        SwitchVCamSuivisJoueur();
    }
}
