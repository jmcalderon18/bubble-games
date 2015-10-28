using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivarImagenTemporal : MonoBehaviour {

	public GameObject changeImage;

	/** 
     * Metodo Start sobrescrito de la clase <code>MonoBehaviour</code>.<P>
     * En este metodo se asigna el script al objeto BarraPuntos, el metodo
     * se inializa junto al objeto
     */
	void Start()
	{
		BarraPuntos.activeImagTemporalUnique = this;
	}

	/**
	 * Metodo utilizado para mostrar la imagen de levelUP
	 */
	public void changeImageWin()
	{
		changeImage.SetActive(true);
	}
}
