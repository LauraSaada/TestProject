using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour {

    public float animationSpeed = 1f;
    public Vector3 animationScale = new Vector3(0f, 1f, 0f);

    private Vector3 initScale;

	// Use this for initialization
	void Start () {
        initScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = initScale + animationScale * Mathf.Sin(Time.time * animationSpeed);
	}
}
