using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Image healthBarFill;
    public void UpdateHealth(float fraction)
    {
        healthBarFill.fillAmount = fraction;
    }
}
