using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    public float vitesse = 0.5f; // Déclaration variable pour gérer la vitesse depuis Unity directement grâce au "public"


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Deplacement();
        Saut();


	}

    void Deplacement()
    {
        float temps = Time.deltaTime;
        Transform transform = GetComponent<Transform>(); //Déclaration de la variable transform qui est un composant (qui est un objet) Transform. On lui assigne le composant Transform de Cube
        Vector3 deplacement = new Vector3(0, 0, vitesse * temps); // Déclaration nouvelle variable : Création d'un objet Vector3 deplacement qui permettra de modifier la position (en s'ajoutant)
        transform.position = transform.position + deplacement; //On assigne une nouvelle valeur position (dans transform), qui est égale à la position dans transform + la valeur de deplacement
    }
    void Saut()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Debug.Log("Pressed left click.");
        }

    
    }


}
