using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimineto : MonoBehaviour
{
    //variables al dejarlo publico lo podemos mocidficar desde el unity y ir probandolo no modifiacndolo porque aca creo que no cambia
    public float velocidad = 5f;//cuando le ponemos un numero a la variable (un valor seria) al lado siempre va la letra f
    
    // Start is called before the first frame update funciona solo para cuando se ejecute el juego
    void Start()
    {
        
    }
    //inputs entreda de informaciom 
    // Update is called once per frame dentro movimiento del jugador
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){//cuando se presione la letra w va a pasar tal cosa...posicion del transform(x,y,z)
            transform.Translate(new Vector3(0, 0, velocidad)* Time.deltaTime);//aca indicamos que va a pasar con su posicion ej: cuando aprete w se ava  mover hacia adelante 1cm?
        }
        if (Input.GetKey(KeyCode.S)) { 
            transform.Translate(new Vector3(0, 0, -velocidad) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-velocidad, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocidad, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))//para que salte se remplaca con space 
        {
            transform.Translate(new Vector3(0,velocidad,0) * Time.deltaTime);
        }
    }
}
