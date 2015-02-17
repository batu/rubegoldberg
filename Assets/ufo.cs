using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ufo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	Vector3 arc1 = new Vector3(383.71f, -3.0f, 345.0f);
	Vector3 arc2 = new Vector3(630.41f, 22.0f, 1224.0f);
	Vector3 arc3 = new Vector3(1519.7f, -1.60f, 1213.0f);
	Vector3 arc4 = new Vector3(1699.61f, -3.0f, 541.0f);
	Vector3 arc5 = new Vector3(1416.71f, -3.0f, 192.0f);
	Vector3 house = new Vector3(1528.91f, 10.0f, 1548.0f);

	public Text Text;

	// Update is called once per frame
	void Update () {
		float boost = 1.5f;
		if (Input.GetKey (KeyCode.LeftShift)){
			boost = 3.0f;
		} else {
			boost = 1.5f;
		}

		if ( Input.GetKey ( KeyCode.A ) ) 
		{ // Time.deltaTime is the fraction of a second in between a frame
			// a value that gets bigger with low FPS, smaller with high FPS
			transform.Rotate(Vector3.down * Time.deltaTime*100);
		}

		if ( Input.GetKey ( KeyCode.D ) ) 
		{ // Time.deltaTime is the fraction of a second in between a frame
			// a value that gets bigger with low FPS, smaller with high FPS
			transform.Rotate(Vector3.up * Time.deltaTime*100);
		}

		if ( Input.GetKey ( KeyCode.W ) ) 
		{ // Time.deltaTime is the fraction of a second in between a frame
			// a value that gets bigger with low FPS, smaller with high FPS
			transform.position += transform.right * Time.deltaTime * 100 * boost ;
		}

		if ( Input.GetKey ( KeyCode.S ) ) 
		{ // Time.deltaTime is the fraction of a second in between a frame
			// a value that gets bigger with low FPS, smaller with high FPS
			transform.position -= transform.right * Time.deltaTime * 100 * boost;
		}

		if ( Input.GetKey ( KeyCode.Space) ){
			float distance = Vector3.Distance(transform.position, new Vector3(812.2f, 10.2f, 704.7f));
			if( distance < 100.0f) {
				Text.text = "YOU WIN! CONGRATULATIONS!";
			}
		} 
	
		if ( 60.4f > Vector3.Distance(transform.position, arc1) ){
			Text.text = "Good job! Keep at it and do not leave the valley untill you see warmer temperatures!";
		}
		if ( 60.4f > Vector3.Distance(transform.position, arc2) ){
			Text.text = "Well done, you stayed on track. Keep moving!";
		}
		if ( 60.4f > Vector3.Distance(transform.position, arc3) ){
			Text.text = "You need to find the house in the desert. The witch living there will guide you."; 
		}
		if ( 60.4f > Vector3.Distance(transform.position, arc4) ){
			Text.text = "You managed to cross the endless desert. Move on!";
		}
		if ( 60.4f > Vector3.Distance(transform.position, arc5) ){
			Text.text = "You need to pass through the narrow mountains! The treasure awaits you If you can pass unscathed.";
		}
		if ( 60.4f > Vector3.Distance(transform.position, house) ){
			Text.text = "The Witch Screams: Turn back and cross the dessert! Reach the grasslands on the other side!";
		}
	
	
	}
}