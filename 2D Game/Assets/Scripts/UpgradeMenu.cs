using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour {

	[SerializeField]
	private Text healthText;

	[SerializeField]
	private Text speedText;

	[SerializeField]
	private int healthUpgradeCost = 30;
	[SerializeField]
	private int speedUpgradeCost = 10;

	private PlayerStats stats;

	void OnEnable ()
	{
		stats = PlayerStats.instance;
		UpdateValues();
    }

	void UpdateValues ()
	{
		healthText.text = "HEALTH: " + stats.maxHealth.ToString();
		speedText.text = "SPEED: " + stats.movementSpeed.ToString();
    }

	public void UpgradeHealth ()
	{
		if (GameMaster.Money < healthUpgradeCost)
		{
			AudioManager.instance.PlaySound("NoMoney");
			return;
		}

		stats.maxHealth = (int)(stats.maxHealth + 25);

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

		stats.movementSpeed = Mathf.Round (stats.movementSpeed + 5);

		GameMaster.Money -= speedUpgradeCost;
		AudioManager.instance.PlaySound("Money");

		UpdateValues();
	}

}
