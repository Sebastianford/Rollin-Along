using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "fail")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Death");
        }

        if (other.tag == "goal")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Victory");
        }
    }

}
