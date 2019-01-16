
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool GameHasEnded = false; 
	public float delay= 1f;

	public void EndGame(){
		if(GameHasEnded==false){

			GameHasEnded = true;
			Debug.Log ("game over");
			Invoke ("Restart", delay);

		}

	

}

	void Restart(){

		SceneManager.LoadScene(SceneManager.GetActiveScene ().name);

	}


}
