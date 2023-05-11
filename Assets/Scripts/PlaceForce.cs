using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceForce : MonoBehaviour
{
    [SerializeField] private GameObject popUp;
    private Camera mainCamera;
    private LayerMask terrainMask = (1 << 6);
    private float rotationY;
    private bool isPlaced;
    public bool IsPlaced
    {
        get => isPlaced;
        set
        {
            isPlaced = value;
        }
    }
    private bool isRotated;
    public bool IsRotated
    {
        get => isRotated;
        set
        {
            isRotated = value;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        PlaceOnTerrain();
        SelectRotation();

    }

    void PlaceOnTerrain()
    {
        if (!isPlaced)
        {
            Vector3 mousePoint = Input.mousePosition;
            Ray ray = mainCamera.ScreenPointToRay(mousePoint);
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, terrainMask))
            {
                transform.position = hit.point;
                if (Input.GetMouseButtonDown(0))
                {
                    SelectRotation();
                    isPlaced = true;
                }
            }
        }

    }

    void SelectRotation()
    {
        if (!isRotated)
        {
            rotationY = Input.GetAxis("Mouse X");
            transform.eulerAngles += new Vector3(0, rotationY * 5f, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                isRotated = true;
                popUp.SetActive(true);
            }
        }

    }

}
