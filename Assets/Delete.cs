using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private GameObject unitychan;
    private float difference2;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        this.difference2 = unitychan.transform.position.z - this.transform.position.z;

        if (this.difference2 >= 6)
        {
            Destroy(this.gameObject);
        }
       
    }
}
