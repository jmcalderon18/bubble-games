using UnityEngine;
using System.Collections;

public class GUIFunctions : MonoBehaviour {

	/**
	 * Metodo utilizado para cambiar entre escenas
	 * @param name identifica el nombre de la escena que sera cargada
	 */
	public void changeScene(string name)
	{
		Application.LoadLevel(name);
	}

}
