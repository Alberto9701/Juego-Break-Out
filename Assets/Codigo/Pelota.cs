using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    //se crea una varible de tipo Rigidbody para poder manipular
    //su transform
    Rigidbody rig;
    //se crea una variable que indicara la velocidad con la que ira la
    //pelota
    public float velocidadInicial = 600f;
    //se crea una varible buleana llamada en juego que indicara
    //si se esta jugando o no
    bool enJuego = false;
    //hacemos lo mismo que hicimos en la clase barra,
    /*
     * creamos una varible que se encargara de almacenar 
     * la posición inicial de la pelota para que cuando se reinicie
     * la partida, la pelota se regrese a esa posición
     */
    Vector3 posicionInicial;
    //cramos una variable de tipo transform para manipular 
    /*
     * el emparentamiento de la barra y la pelota
     */
    Transform barra;
    /*
     * creamos una varible de la clase vidas que creamos para
     * llevar una cuenta de las vidas que llevamos
     */
    Vidas vidas;
    /*
     * se crea una varible para validar que cuando se pulse la 
     * pantalla una vez estando en la escena uno del juego
     * la pelota saldra disparada
     */
    public ElementoInteractivo pantalla;
    /*
     * recordemos que en el awake se obtienen los componenetes
     * de las varibles que requerimos
     */
    void Awake()
    {
        //se obtienen los valores de las variables
        rig = GetComponent<Rigidbody>();
        barra = transform.parent;

    }
    // Start is called before the first frame update
    void Start()
    {
        //se indica el valor de la posicion inicial la cual es
        //con la que inicia el juego
        posicionInicial = transform.position;
    }

    //creamos un metodo llamado reset que dira lo que pasara
    //una vez que la pelota caiga al suelo y se reinicie en la escena
    public void Reset()
    {
        transform.position = posicionInicial;
        //se emparentare con la barra nuevamente
        transform.SetParent(barra);
        //enJuego pasara a false ya que no se ha disparado 
        //la pelota
        enJuego = false;
        //se llama al metodo detener movimiento
        DetenerMovimiento();
    }

    //se crea un metodo llamado detener movimiento
    //el cual nos dira lo lo que pasa una vez que la pelota se
    //reinicia en la posicion de su padre osea la barra
    public void DetenerMovimiento()
    {
        /*
         * se vuelve kinematico para que no obedesca las
         * fisicas de unity y se pueda disparar con  fire1 o
         * pulsando la pantalla
         */
        rig.isKinematic = true;
        //su velocidad se vuelve cero ya que aun no la hemos disparado
        rig.velocity = Vector3.zero;
    }
    

    // Update is called once per frame
    void Update()
    {
        /*
         * se evalua si en juego es false
         * osea que no hemos disparado y ademas si se ha presionado
         * fire 1 o si se ha presionado la pantalla
         */
        if (enJuego == false && (Input.GetButtonDown("Fire1") || pantalla.pulsado==true))
        {
            /*
             * si es verdadero ambas afirmaciones, la pelota se disparara
             * enJuego entrara en true, de desparentara la pelota de la barra
             * , volvera a obedecer las fisicas de unity ya que ya ha sido 
             * disparado, y finalmente se le añadira una fuerza para que rebote
             * con el valor de la velocidad inicial que dijimos en un principio
             */
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));
            
        }
        
        
        
    }
}
