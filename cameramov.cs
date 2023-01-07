using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramov : MonoBehaviour
{
    public Transform player;
    public float sensibilita;
    float rotazione;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	float x = Input.GetAxis("Mouse X") * Time.deltaTime * sensibilita;
 	float y = Input.GetAxis("Mouse Y") * Time.deltaTime * sensibilita;

	rotazione -= y;
	rotazione = Mathf.Clamp(rotazione, -60f, 60f);

	transform.localRotation = Quaternion.Euler(rotazione, 0, 0);

	player.Rotate(Vector3.up * x);	
    }
}
