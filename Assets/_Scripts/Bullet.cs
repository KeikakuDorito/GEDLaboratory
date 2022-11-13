using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private void OnEnable()
    {
        transform.GetComponent<Rigidbody>().WakeUp();
    }

    private void Disable()
    {
        transform.GetComponent<Rigidbody>().Sleep();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);

        if(collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
