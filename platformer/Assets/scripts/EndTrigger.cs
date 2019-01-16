using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTrigger : MonoBehaviour {


	void OnTriggerEnter(){

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

	}

}
