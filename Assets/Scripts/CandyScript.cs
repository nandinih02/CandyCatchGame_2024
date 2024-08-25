using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //increment score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Boundary")
        {
            //Decrease Lives
            Destroy(gameObject);
            GameManager.instance.DecreaseLife();
        }
    }
}
