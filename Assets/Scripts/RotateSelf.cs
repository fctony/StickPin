using UnityEngine;

public class RotateSelf : MonoBehaviour {

    public float speed = 90;

	void Update () {
        transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
	}
}
