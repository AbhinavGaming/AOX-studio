
using UnityEngine;

public class playermovement : MonoBehaviour {

	public Rigidbody rb;
	public float ab=25;
	public float bc=1000;
    public Joystick joyo;


	// Update is called once per frame
	void Update () {

		rb.AddForce (0, 0, bc * Time.deltaTime);

		if(joyo.Horizontal>= .2f){
        
			rb.AddForce (ab*Time.deltaTime, 0 , 0,ForceMode.VelocityChange);

		}

		if(joyo.Horizontal <= -.2f)
        {

			rb.AddForce (-ab*Time.deltaTime, 0 , 0, ForceMode.VelocityChange);

		}

		if(joyo.Vertical>= .2f){

			rb.AddForce (0, 20*Time.deltaTime , 0, ForceMode.VelocityChange);

		}

        if (joyo.Vertical <= -.2f)
        {

            rb.AddForce(0,0, -35 * Time.deltaTime, ForceMode.VelocityChange);

        }

        if (rb.position.y< -1f){

			FindObjectOfType<GameManager> ().EndGame();

	}
}
}
