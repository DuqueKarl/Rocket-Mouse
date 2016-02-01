using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

	// Laser Sprites for On and Off states
	public Sprite laserOnSprite;
	public Sprite laserOffSprite;
	// Time in every state before toggling
	public float interval = 0.5f;
	// Laser rotation speed clockwise
	public float rotationSpeed = 0.0f;

	private bool isLaserOn = true;
	private float timeUntilNextToggle;
	private Collider2D collider2d;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		timeUntilNextToggle = interval;
		collider2d = GetComponent<Collider2D> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	

	void FixedUpdate() {
		timeUntilNextToggle -= Time.fixedDeltaTime;
		
		// Update laser graphic
		if (timeUntilNextToggle <= 0) {
			isLaserOn = !isLaserOn;

			collider2d.enabled = isLaserOn;

			if (isLaserOn) {
				spriteRenderer.sprite = laserOnSprite;
			} else {
				spriteRenderer.sprite = laserOffSprite;
			}

			timeUntilNextToggle = interval;
		}
		
		// Rotate clockwise
		transform.RotateAround(transform.position, Vector3.forward, rotationSpeed * Time.fixedDeltaTime);
	}

}
