using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField] private GameObject popUp;
    [SerializeField] private GameObject force;
    private PlaceForce placeForce;

    private void Start()
    {
        placeForce = force.GetComponent<PlaceForce>();
    }

    void Update()
    {
        LookAtPlayer();
    }

    /// <summary>
    /// Changes the rotation of the marker (canvas) based on the player's rotation & position 
    /// </summary>
    void LookAtPlayer()
    {
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);

    }

    public void DeleteForce()
    {
        popUp.SetActive(false);
        Destroy(force);
    }

    public void EditForce()
    {
        popUp.SetActive(false);
        placeForce.IsPlaced = false;
        placeForce.IsRotated = false;
    }

    public void CloseOptions()
    {
        popUp.SetActive(false);
    }
}
