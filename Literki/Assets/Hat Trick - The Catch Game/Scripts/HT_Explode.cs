using UnityEngine;
using System.Collections;

public class HT_Explode : MonoBehaviour {

	public GameObject explosion;


    void OnTriggerEnter2D(Collider2D other)
    
        {
		if (other.gameObject.tag == "Hat") {
			Instantiate (explosion, transform.position, transform.rotation);
			
			Destroy (gameObject);
		}
	}
}
