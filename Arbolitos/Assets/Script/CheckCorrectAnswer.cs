using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckCorrectAnswer : MonoBehaviour {


	public GameObject gameObjectBurbuja; //Prefab de la burbuja
	public BarraPuntos barraPtsChangeBarra;

	/**
	 * Metodo utilizado para verificar si una respuesta es correcta o falsa
	 * @param buttonThis del que debe verificarse la informacion y reconocer si la respuesta es correcta
	 */
	public void checar(GameObject buttonThis)
	{
		Boton other = buttonThis.GetComponent<Boton>(); //A partir del GameObject encontrar el componente boton

		if(other.boolRespuesta())
		{
			GameObject.Destroy(other.miBurbuja);
			BarraPuntos.goodAnswer();
		}

		else
		{
			Button buttonReferenceButton = buttonThis.GetComponent<Button>(); //A partir del GameObject encontrar el componente Button
			buttonReferenceButton.enabled= false;
			GameObject newBubble = Instantiate(gameObjectBurbuja,
			                                   new Vector3(other.miBurbuja.transform.position.x-550,other.miBurbuja.transform.position.y-200,0),
			                                   Quaternion.identity)  as GameObject;
			newBubble.transform.SetParent(GameObject.FindObjectOfType<Canvas>().gameObject.transform, false);
			BarraPuntos.wrongAnswer();

		}
	}
}
