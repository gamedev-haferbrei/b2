using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FuelBar : MonoBehaviour
{
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject textGO;

    Image image;
    Player player;
    
    TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        player = playerGO.GetComponent<Player>();
        text = textGO.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = player.fuel;
        text.text = player.fuel == 0 ? "Empty" : $"{(int)(player.fuel * 100)}%";
    }
}
