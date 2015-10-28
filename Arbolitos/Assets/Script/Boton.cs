using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Boton : MonoBehaviour{

	public string strIDBoton; //ID de cada botón
	public bool respuestaCorrecta; //Indicar cual es la resputa correcta

	[HideInInspector]
	public GameObject miBurbuja; //Identificar cual es la burbuja a la que pertenece el boton

	/**
	 * Metodo utilizado para asignar el ID de un boton
	 * @param ID es el ID identificador del objeto
	 */
	public void setID(string ID)
	{
		strIDBoton = ID;
	}

	/**
	 * Metodo utilizado para asignar el ID de un boton
	 * @return un valor string que representa el ID del objeto
	 */
	public string strGetID()
	{
		return strIDBoton;
	}

	/**
	 * Metodo utilizado saber si es el boton que tiene la respuesta correcta
	 * @return un valor booleano que determina si tiene la respuesta correcta
	 */
	public bool boolRespuesta()
	{
		asignarBurbuja();
		return respuestaCorrecta;
	}

	/**
	 * Metodo utilizado para encontrar la burbuja a la que pertenece el botón
	 */
	void asignarBurbuja()
	{
		miBurbuja = this.transform.parent.gameObject;
	}

}
