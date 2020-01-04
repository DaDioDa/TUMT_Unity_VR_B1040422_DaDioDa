using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Range(0.1f,1f)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        bulletfly();
    }

    void bulletfly()
    {
        this.transform.position += transform.forward*speed;
        if(this.transform.position.z <= -60)
        {
            Destroy(gameObject);
        }
    }

}
