using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarraPuntos : MonoBehaviour {

	public static int iSize = 793; //Tamano de la imagen barra
	private static float spaceForWater = 0; //Espacio que aumenta el agua en una respuesta correcta
	private static float initialPosition; //Posicion inical de la imagen
	public static int iTotalAnswers = 4; //Numero total de preguntas
	public  static int iCorrectAnswers = 0; //Respuestas correctas
	public static Image imaBarra; //Imagen de la barra dea gua

	public static ActivarImagenTemporal activeImagTemporalUnique; //Cambia imagen de la UI


	/** 
     * Metodo Start sobrescrito de la clase <code>MonoBehaviour</code>.<P>
     * En este metodo se inicializa la imaBarra, se obtiene el valor del spaceForWater al inicio del proyecto
     * y se obtiene la posicion inicial de la imaBarrra
     */
	void Start () {
		imaBarra = this.GetComponentInChildren<Image>();
		spaceForWater = iSize / iTotalAnswers;
		initialPosition =-373;

		iCorrectAnswers = 0;
		iTotalAnswers = 4;

	}

	/**
	 * Metodo mandado a llamar cuando se da una respuesta correcta
	 * Modifica la cantidad de agua acumulada y si se tienen el número total de respuestas correcta cambiar la imagen a levelUP
	 */
	public static void goodAnswer()
	{
		iCorrectAnswers++;
		imaBarra.transform.position =  new Vector3(initialPosition + (iCorrectAnswers*spaceForWater),imaBarra.rectTransform.position.y,0);
		if(iCorrectAnswers>=iTotalAnswers) 
		{
			activeImagTemporalUnique.changeImageWin();

		}

	}

	/**
	 * Metodo mandado a llamar cuando se da una respuesta incorrecta
	 * Aumenta la cantidad de preguntas que deben estar correctas para que se concluya el juego
	 * Cambia la cantidad de agua acumulable por cada pregunta
	 * Reajusta la cantidad de agua obtenida en relacion a la nueva cantidad de agua acumulable por pregunta
	 */
	public static void wrongAnswer()
	{
		iTotalAnswers++;
		spaceForWater = iSize / iTotalAnswers;
		imaBarra.transform.position =  new Vector3(initialPosition + (iCorrectAnswers*spaceForWater),imaBarra.rectTransform.position.y,0);

	}
}
