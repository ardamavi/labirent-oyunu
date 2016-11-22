using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public int hiz = 25;

	// Use this for initialization
	void Start () {
	
		Debug.Log ("Oyun Başladı !");

		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("escape")){
			Debug.Log ("Oyun'dan Çıkılıyor ...");
			Application.Quit();
	     }

		if (Input.GetKey ("w")) {
			Debug.Log ("Yukarı");
			rb.AddForce (transform.forward * hiz);
		}
		if (Input.GetKey ("s")) {
			Debug.Log ("Aşağı");
			rb.AddForce (transform.forward * -hiz);
		}
		if (Input.GetKey ("a")) {
			Debug.Log ("Sol");
			rb.AddForce (transform.right * -hiz);
		}
		if (Input.GetKey ("d")) {
			Debug.Log ("Sağ");
			rb.AddForce (transform.right * hiz);
		}
	
	}

	void OnCollisionEnter (Collision degen){
	
		if (degen.gameObject.tag == "Enemy") {
		
			Debug.Log ("Kaybettin !");

			Destroy (gameObject);

			Application.LoadLevel(Application.loadedLevel);
		
		}

		if (degen.gameObject.tag == "Finish") {

			Debug.Log ("Kazandın !");

			Destroy (gameObject);

			Application.LoadLevel (Application.loadedLevel + 1);

		}
	
	}
}
