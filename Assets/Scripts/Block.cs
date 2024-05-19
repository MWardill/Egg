using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject Egg;
    
    public float distance = 5f;
	public float rotationSpeed = 1f; 
	public float angle = 0f;

	private Vector3 anchor;
	

	// Start is called before the first frame update
	void Start()
    {
		var sprite = Egg.GetComponent<SpriteRenderer>();
		var bounds = sprite.bounds;
		anchor = sprite.bounds.center;

		angle = 180;
	}

    // Update is called once per frame
    void Update()
    {

		var radians = angle * Mathf.Deg2Rad;

		float x = Mathf.Cos(radians) * distance;
		float y = Mathf.Sin(radians) * distance;
		var offset = new Vector3(x, y, 0f);
		this.transform.position = anchor + offset;
						
		angle += rotationSpeed * Time.deltaTime;

		Vector3 direction = (transform.position - anchor).normalized;
		//float rotationAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		float rotationAngle = angle + 270;
		transform.rotation = Quaternion.Euler(0, 0, rotationAngle);

		if (angle >= 360)
		{
			angle -= 360f;
		}
	}
}
