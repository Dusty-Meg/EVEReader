using System;

public class Character
{
    string keyID; // Public
    string verificationCode; // Public
    string characterID; // Public

    int[] balanceDate; // Private
    int balanceAmount; // Public

	public Character(string keyIDPass, string verificationCodePass, string characterIDPass)
	{
        keyID = keyIDPass;
        verificationCode = verificationCodePass;
        characterID = characterIDPass;
	}

    public void balanceUpdater()
    {

    }

    static int[] dateUpdater(string data)
    {
        int[] date = new int[6];

        date[0] = int.Parse(data.Substring(0, 4));
        date[1] = int.Parse(data.Substring(5, 2));
        date[2] = int.Parse(data.Substring(8, 2));
        date[3] = int.Parse(data.Substring(11, 2));
        date[4] = int.Parse(data.Substring(14, 2));
        date[5] = int.Parse(data.Substring(17, 2));

        return date;
    }
}
