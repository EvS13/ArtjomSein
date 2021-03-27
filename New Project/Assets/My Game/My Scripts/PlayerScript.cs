using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

	public int coins;
	public GameObject finalCutScene;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{

		finalCutScene.SetActive(false);
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided)
	{

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin")
		{

			Destroy(collided.gameObject);
			coins++;
			HUD.Message("You collected a coin!");
			HUD.UpdateCoinCount(coins);

		}

		if (collided.gameObject.name == "Powerup")
		{
			Destroy(collided.gameObject);
			Abilities.doubleJumpEnabled = true;
			HUD.Message("Now you can jump higher!");
		}

		if (collided.gameObject.name == "Powerup2")
		{
			Destroy(collided.gameObject);
			Abilities.spinAttackEnabled = true;
			HUD.Message("Now you got second PowerUp! Go find rising 
				using UnityEngine;
			using System.Collections;

public class PlayerScript : MonoBehaviour
	{

		public int coins;
		public GameObject finalCutScene;

		protected void Start()
		{

			finalCutScene.SetActive(false);
		}

		protected void OnTriggerEnter(Collider collided)
		{

			if (collided.gameObject.tag == "Coin")
			{

				Destroy(collided.gameObject);
				coins++;
				HUD.Message("You collected a coin!");
				HUD.UpdateCoinCount(coins);

			}
			if (collided.gameObject.name == "Powerup")
			{
				Destroy(collided.gameObject);
				Abilities.doubleJumpEnabled = true;
				HUD.Message("Now you can jump higher!");
			}

			if (collided.gameObject.name == "Powerup2")
			{
				Destroy(collided.gameObject);
				Abilities.spinAttackEnabled = true;
				HUD.Message("Now you got second PowerUp! Go find rising platform to go to Level3!");
			}

			if (collided.gameObject.tag == "Final")
			{
				finalCutScene.SetActive(true);
			}
		}
	}
