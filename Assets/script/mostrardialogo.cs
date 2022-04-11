using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mostrardialogo : MonoBehaviour
{
    private mostrardialogo mostrarDialogo;
    public GameObject  canvas;
    private GameObject cuadro;
    public GameObject mensajeprefab;
    public void mostrar()
    {
        canvas.SetActive(true);
        cuadro = Instantiate(mensajeprefab, canvas.transform);
        //mostrar mensaje en el cuadro
 cuadro.GetComponentInChildren<Text>().text = "te quiero camelo";
    }
    public void cerrar()
    {
        Destroy(cuadro);
    }
    public void Onclick()
    {
        mostrar();
          }
}
