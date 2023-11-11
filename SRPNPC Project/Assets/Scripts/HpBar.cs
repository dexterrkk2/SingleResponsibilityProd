using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
	private Slider _slider;
	private Text text;
	private void Start()
	{
		_slider = GetComponentInChildren<Slider>();
		text = GetComponentInChildren<Text>();
		text.text = name;
		GetComponentInParent<IHealth>().OnHPPctChanged += HandleHPPctChanged;
	}

	private void HandleHPPctChanged(float pct)
	{
		_slider.value = pct;
	}
}