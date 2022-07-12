using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load("Meteor") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject Meteorite = Instantiate(prefab) as GameObject;
            Meteorite.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = Meteorite.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 70;
        }

    }

}