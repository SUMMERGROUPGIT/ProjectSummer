using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; //разблокируем курсор
        Cursor.visible = true; //заставляем курсор мыши появиться
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
