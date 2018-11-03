using UnityEngine;

public class BoxCollision : MonoBehaviour {

    public GameObject splat;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(splat, gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }


}
