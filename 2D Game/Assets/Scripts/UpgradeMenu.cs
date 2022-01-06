using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour {

	[SerializeField]
	private Text healthText;

	[SerializeField]
	private Text speedText;

	[SerializeField]
	private Text livesText;

	[SerializeField]
	private int healthIncreaseValue = 25;

	[SerializeField]
	private int speedIncreaseValue = 5;

	[SerializeField]
	private int healthUpgradeCost = 50;
	
	[SerializeField]
	private int speedUpgradeCost = 50;
	
	[SerializeField]
	private int livesIncreaseCost = 10;

	private PlayerStats stats;

	void OnEnable ()
	{
		stats = PlayerStats.instance;
		UpdateValues();
    }

	void UpdateValues ()
	{
		healthText.text = "HEALTH:" + stats.maxHealth.ToString();
		speedText.text = "SPEED:" + stats.movementSpeed.ToString();
		livesText.text = "Lives:" + GameMaster._remainingLives.ToString();

    }

	public void UpgradeHealth ()
	{
		if (GameMaster.Money < healthUpgradeCost)
		{
			AudioManager.instance.PlaySound("NoMoney");
			return;
		}

		stats.maxHealth = (int)(stats.maxHealth + healthIncreaseValue);

		GameMaster.Money -= healthUpgradeCost;
		AudioManager.instance.PlaySound("Money");

		UpdateValues();
	}

	public void UpgradeSpeed()
	{
		if (GameMaster.Money < speedUpgradeCost)
		{
			AudioManager.instance.PlaySound("NoMoney");
			return;
		}

		stats.movementSpeed = Mathf.Round (stats.movementSpeed + speedIncreaseValue);

		GameMaster.Money -= speedUpgradeCost;
		AudioManager.instance.PlaySound("Money");

		UpdateValues();
	}

	public void IncreaseLives()
	{
		if (GameMaster.Money < livesIncreaseCost)
		{
			AudioManager.instance.PlaySound("NoMoney");
			return;
		}

		int tempLivesHolder = GameMaster._remainingLives;
		GameMaster._remainingLives = tempLivesHolder + 1;

		GameMaster.Money -= livesIncreaseCost;
		AudioManager.instance.PlaySound("Money");

		UpdateValues();
	}

}
