using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float fowardForce = 2000f;
	public float sidewaysForce = 500f;
	
	// Es mejor utilizar FixedUpdate en vez de Update para la física del juego.
	void FixedUpdate () {
		rb.AddForce (0, 0, fowardForce * Time.deltaTime); // Time.deltaTime compensa los FPS para todos los sistemas.

		if (Input.GetKey("d")){
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")){
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
