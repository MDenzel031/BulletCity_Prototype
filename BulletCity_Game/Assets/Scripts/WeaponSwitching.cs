using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{

    public int selectedWeapon = 0;

    private int currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
        currentWeapon = selectedWeapon;
        selectedWeapon = PlayerPrefs.GetInt("SelectedWeapon", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (currentWeapon != selectedWeapon)
        {
            SelectWeapon();
        }

    }

    void SelectWeapon()
    {
            int i = 0;
            foreach(Transform weapon in transform)
            {
                if(i == selectedWeapon)
                {
                    weapon.gameObject.SetActive(true);
                    currentWeapon = i;
                }
                else
                {
                    weapon.gameObject.SetActive(false);
                }
                i++;
            }
    }
}
