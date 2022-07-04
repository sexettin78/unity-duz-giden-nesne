using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class duzgidenaraba : MonoBehaviour
{
    
    public float hiz = 0.1f;
    void Start()
    {
        
    }


    void Update()
    {
      
        var pos = transform.position;
        pos.z += hiz;
        transform.position = pos;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(8);
        }
    }
}
