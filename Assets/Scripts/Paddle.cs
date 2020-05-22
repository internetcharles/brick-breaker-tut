using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector3 paddlePos = new Vector3(mouseX, 0.47f, 1);
        transform.position = paddlePos;

    }
}
