using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject firepoint, bullet;

    // Start is called before the first frame update
    void Start()
    {
        callshoot();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void shootit()
    {
        Instantiate(bullet, firepoint.transform.position,Quaternion.Euler(Random.Range(5,-5),Random.Range(173,187),1)).SetActive(true);
    }

    public void callshoot()
    {
        InvokeRepeating("shootit", 0.5f, 0.15f);
    }

}
