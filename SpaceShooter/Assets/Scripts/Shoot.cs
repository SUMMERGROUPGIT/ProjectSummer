using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 5.0f; //переменная для урона
    public float range = 50.0f; //переменная для дальности с трельбы
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//блокировка курсора
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {//если нажимаем на левую кнопку мыши
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);//создаем точку в центре экрана
            Ray ray = cam.ScreenPointToRay(point);//направляем луч в ранее созданную точку
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, range))
            {
                Debug.Log(hit.transform.name);// выводи в консоль имя объекта, в который попали
            }
        }
    }
}
