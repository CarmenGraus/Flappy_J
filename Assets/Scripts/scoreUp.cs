using UnityEngine;
using System.Collections;

public class scoreUp : MonoBehaviour {

	public class scoreUp : MonoBehaviour
		 
		private Text texto;
	void Start() {
		texto = GameObject.Find ("TextoNivel").GetComponent<Text>();
	}


	void OnTriggerEnter2D(Collider2D col){
		GameControl.score = GameControl.score + 1;

		texto.text = "Level" + GameControl.score.ToString ();
}
}
