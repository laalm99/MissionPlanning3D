using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject menu;
    [SerializeField] private Transform parentForces;
    [SerializeField] private GameObject hintPage;

    public void ToggleInfo()
    {
        hintPage.active = !hintPage.active;
    }

    public void OpenMenu()
    {
        button.GetComponent<Button>().enabled = false;
        menu.SetActive(true);
    }

    public void GenerateForces(GameObject prefab)
    {
        menu.SetActive(false);
        button.GetComponent<Button>().enabled = true;
        GameObject force = Instantiate(prefab, parentForces);
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
        button.GetComponent<Button>().enabled = true;
    }

    
}
