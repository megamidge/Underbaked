using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour {

    float speed = 5;
    public GameObject splat;
    public IngredientObject ingredient;

    private void Start()
    {
        
    }

    void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Instantiate(splat, gameObject.transform.position, Quaternion.identity);
        //Destroy(this.gameObject);
        if (collision.gameObject.tag != "Player")
            this.gameObject.SetActive(false);
    }
}
