using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector3 vt = new Vector3();
    public Rigidbody rstick;     
    public Rigidbody rball;     
    public GameObject stick1;   
    public GameObject ball;
    public GameObject cam;


    public Transform target;

    public float fRadius = 3.0f;

    public Transform pivot;

    Vector3 unit = new Vector3(1, 0, 1);

    void Start()

    {
        Cursor.visible = false;
        pivot = new GameObject().transform;
        stick1.transform.parent = pivot;
        cam.SetActive(false);

    }

    void Update()

    {

        Roll();

        vt = (ball.transform.position - stick1.transform.position);

        if (Input.GetMouseButtonDown(0))

        {

            stick1.SetActive(false);
            cam.SetActive(true);
            rball.velocity = vt * 3;

        }

        if (Input.GetMouseButtonDown(1))

        {

            stick1.SetActive(true);
            cam.SetActive(false);

        }

    }

    //Controll stick rotate around white ball

    void Roll()

    {

        Vector3 v3Pos = new Vector3();

        v3Pos = Input.mousePosition - v3Pos;

        float angle = Mathf.Atan2(v3Pos.x, v3Pos.y) * 360;

        pivot.position = target.position;

        pivot.rotation = Quaternion.AngleAxis(angle, Vector3.up);

    }
}
