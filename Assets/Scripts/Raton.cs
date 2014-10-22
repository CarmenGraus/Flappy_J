using UnityEngine;
using System.Collections;

public class Raton : MonoBehaviour {

	public int vhorizontal = 1;
	public int vvertical = 1;

	Vector3 movimiento;
	Vector3 posicionRaton;
	

	
	// Update is called once per frame
	void Update () {

				posicionRaton = Input.mousePosition;
		
				posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);		//convertir coordenadas del raton a las coord del juego
		
		
				if (Input.GetMouseButton (0)) {
						transform.position = Vector2.Lerp (transform.position, 
			                                   posicionRaton, vvertical * 0.1f);		//Lerp tiene(destino, origen y velocidad)
						//0.1f para que el desplazamiento cuando pincho sea lenta (menor numero, mas lento)
				}
		}
}
