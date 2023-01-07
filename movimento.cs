using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    
    CharacterController controller;
    public Transform terraCheck;
    float distanzaTerra = 0.01f;
    public LayerMask TerraMask;
    bool toccaterra;
    Vector3 veloy;
    float gravita = -9.8f;
    float altezzasalto = 3f;

    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        //assegno l'oggetto CharacterController alla variabile
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // assegno l'input ale 2 variabili
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

       Vector3 movimento = transform.right * x + transform.forward * z;
	
       controller.Move(movimento * Time.deltaTime * velocity);

        //controllo le collosioni col terreno
       toccaterra = Physics.CheckSphere(terraCheck.position, distanzaTerra, TerraMask);

       if (toccaterra == true && veloy.y < 0)
       {
	       veloy.y = -10f;
       }

       if (Input.GetButtonDown("Jump"))
       {
           if (toccaterra == true)
           {
                veloy.y = Mathf.Sqrt(gravita * altezzasalto * -2f);
           }
       }

       veloy.y += gravita * Time.deltaTime;

       controller.Move(veloy * Time.deltaTime);
    }
}
