using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HT_Restart : MonoBehaviour {

	public void OnMouseDown () {
        //Application.LoadLevel (Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
