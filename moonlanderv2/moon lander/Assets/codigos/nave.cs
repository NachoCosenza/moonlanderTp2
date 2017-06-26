using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour {

    private Rigidbody2D rb;
    public float fuerza;
    public float angle;
    private float vertical = 0f;
	private float rotacion = 0f;
	private float estabilizador = 0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
	}

    void Start ()
    {}
	
	
	void Update ()
    {
		vertical = Input.GetAxisRaw ("volar");
		rotacion = Input.GetAxisRaw ("rotation");
		estabilizador = Input.GetAxisRaw ("estabiliza");

	}
            

    void FixedUpdate()
    {
		rb.AddRelativeForce(Vector3.up * fuerza * vertical);
		rb.AddTorque((rotacion * (-angle)));

		//estabilizador de la nave
		if (estabilizador == 1)
		{
			if (transform.rotation.z < 0)
			{
				rb.AddTorque(angle/2);
			}
			if (transform.rotation.z > 0)
			{
				rb.AddTorque((-angle/2));
			}
		}

    }

    
}
