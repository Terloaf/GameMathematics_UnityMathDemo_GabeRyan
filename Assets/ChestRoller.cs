using JetBrains.Annotations;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ChestRoller : MonoBehaviour
{
    public int[] Chests = new int[5];

    [Header("Chest Type")]
    public int WoodChest;
    public int BronzeChest;
    public int SilverChest;
    public int GoldChest;
    public int PlatinumChest;

    [Header("Wooden Chest")]
    public int WoodChestCommon;
    public int WoodChestUncommon;
    public int WoodChestRare;
    public int WoodChestEpic;
    public int WoodChestLegendary;

    [Header("Bronze Chest")]
    public int BronzeChestCommon;
    public int BronzeChestUncommon;
    public int BronzeChestRare;
    public int BronzeChestEpic;
    public int BronzeChestLegendary;

    [Header("Silver Chest")]
    public int SilverChestCommon;
    public int SilverChestUncommon;
    public int SilverChestRare;
    public int SilverChestEpic;
    public int SilverChestLegendary;

    [Header("Gold Chest")]
    public int GoldChestCommon;
    public int GoldChestUncommon;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Chests[0] = WoodChest;
        Chests[1] = BronzeChest;
        Chests[2] = SilverChest;
        Chests[3] = GoldChest;
        Chests[4] = PlatinumChest;

        for(int i = 0; i < Chests.Length; i++)
        {

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void ChooseChest()
    {

    }


}
