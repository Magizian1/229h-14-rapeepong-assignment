using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GameManager2D : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject offset;

    public static GameManager2D Instance;

    void Start()
    {
        Instance = this;
        mainCamera = Camera.main;

        
    }

    void Update()
    {
        Vector2 mousePosition = GetMouseWorldPosition();
        transform.position = new Vector2(mousePosition.x, mousePosition.y);
        offset.transform.position = new Vector2(mousePosition.x,mousePosition.y);
    }

    private Vector2 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z;
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }
}
