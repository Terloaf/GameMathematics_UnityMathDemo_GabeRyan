using JetBrains.Annotations;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ChestRoller : MonoBehaviour
{
    public GameObject chestText;
    private float ChestTypeTotal = 0;
    private float woodTotal = 0;
    private int woodCurrent = 0;
    private float bronzeTotal = 0;
    private float silverTotal = 0;
    private float goldTotal = 0;
    private float platinumTotal = 0;

    private int[] Chests = new int[5];
    private int[] WoodLoot = new int[5];
    private int[] BronzeLoot = new int[5];
    private int[] SilverLoot = new int[5];
    private int[] GoldLoot = new int[5];
    private int[] PlatinumLoot = new int[5];

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
    public int GoldChestRare;
    public int GoldChestEpic;
    public int GoldChestLegendary;

    [Header("Platinum Chest")]
    public int PlatinumChestCommon;
    public int PlatinumChestUncommon;
    public int PlatinumChestRare;
    public int PlatinumChestEpic;
    public int PlatinumChestLegendary;


    public string[] chestNames;
    public string[] WoodChestPrizes;
    public string[] BronzeChestPrizes;
    public string[] SilverChestPrizes;
    public string[] GoldChestPrizes;
    public string[] PlatinumChestPrizes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chestText.SetActive(false);

        Chests[0] = WoodChest;
        Chests[1] = BronzeChest;
        Chests[2] = SilverChest;
        Chests[3] = GoldChest;
        Chests[4] = PlatinumChest;

        WoodLoot[0] = WoodChestCommon;
        WoodLoot[1] = WoodChestUncommon;
        WoodLoot[2] = WoodChestRare;
        WoodLoot[3] = WoodChestEpic;
        WoodLoot[4] = WoodChestLegendary;

        BronzeLoot[0] = BronzeChestCommon;
        BronzeLoot[1] = BronzeChestUncommon;
        BronzeLoot[2] = BronzeChestRare;
        BronzeLoot[3] = BronzeChestEpic;
        BronzeLoot[4] = BronzeChestLegendary;

        SilverLoot[0] = SilverChestCommon;
        SilverLoot[1] = SilverChestUncommon;
        SilverLoot[2] = SilverChestRare;
        SilverLoot[3] = SilverChestEpic;
        SilverLoot[4] = SilverChestLegendary;

        GoldLoot[0] = GoldChestCommon;
        GoldLoot[1] = GoldChestUncommon;
        GoldLoot[2] = GoldChestRare;
        GoldLoot[3] = GoldChestEpic;
        GoldLoot[4] = GoldChestLegendary;

        PlatinumLoot[0] = PlatinumChestCommon;
        PlatinumLoot[1] = PlatinumChestUncommon;
        PlatinumLoot[2] = PlatinumChestRare;
        PlatinumLoot[3] = PlatinumChestEpic;
        PlatinumLoot[4] = PlatinumChestLegendary;

        for (int i = 0; i < Chests.Length; i++)
        {
            ChestTypeTotal += Chests[i];

        }



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float ChestType = Random.Range(1, ChestTypeTotal);
   
            if (ChestType <= WoodChest)
            {
                for (int i = 0; i < WoodLoot.Length; i++)
                {
                    bronzeTotal += BronzeLoot[i];

                }
                float woodLootPool = Random.Range(1, bronzeTotal);


                if (woodLootPool <= WoodChestCommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Common Wood Loot";
                    woodTotal = 0;
                }

                else if (woodLootPool <= WoodChestCommon + WoodChestUncommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Uncommon Wood Loot";
                    woodTotal = 0;
                }
                else if (woodLootPool <= WoodChestCommon + WoodChestUncommon + WoodChestRare)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Rare Wood Loot";
                    woodTotal = 0;
                }
                else if (woodLootPool <= WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Epic Wood Loot";
                    woodTotal = 0;
                }
                else if (woodLootPool <= WoodChestCommon + WoodChestUncommon + WoodChestRare + WoodChestEpic + WoodChestLegendary)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Legendary Wood Loot";
                    woodTotal = 0;
                }
            }




            else if (ChestType <= BronzeChest + WoodChest)
            {
                for (int i = 0; i < BronzeLoot.Length; i++)
                {
                    bronzeTotal += BronzeLoot[i];

                }
                float bronzeLootPool = Random.Range(1, bronzeTotal);

                if (bronzeLootPool <= BronzeChestCommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Common Bronze Loot";
                    bronzeTotal = 0;
                }
                else if (bronzeLootPool <= BronzeChestCommon + BronzeChestUncommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Uncommon Bronze Loot";
                    bronzeTotal = 0;
                }
                else if (bronzeLootPool <= BronzeChestCommon + BronzeChestUncommon + BronzeChestRare)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Rare Bronze Loot";
                    bronzeTotal = 0;
                }
                else if (bronzeLootPool <= BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Epic Bronze Loot";
                    bronzeTotal = 0;
                }
                else if (bronzeLootPool <= BronzeChestCommon + BronzeChestUncommon + BronzeChestRare + BronzeChestEpic + BronzeChestLegendary)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Legendary Bronze Loot";
                    bronzeTotal = 0;
                }


            }

            else if (ChestType <= SilverChest + BronzeChest + WoodChest)
            {
                for (int i = 0; i < SilverLoot.Length; i++)
                {
                    silverTotal += SilverLoot[i];

                }
                float SilverLootPool = Random.Range(1, silverTotal);

                if (SilverLootPool <= SilverChestCommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Common Silver Loot";
                    silverTotal = 0;
                }
                else if (SilverLootPool <= SilverChestCommon + SilverChestUncommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Uncommon Silver Loot";
                    silverTotal = 0;
                }
                else if (SilverLootPool <= SilverChestCommon + SilverChestUncommon + SilverChestRare)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Rare Silver Loot";
                    silverTotal = 0;
                }
                else if (SilverLootPool <= SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Epic Silver Loot";
                    silverTotal = 0;
                }
                else if (SilverLootPool <= SilverChestCommon + SilverChestUncommon + SilverChestRare + SilverChestEpic + SilverChestLegendary)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Legendary Silver Loot";
                    silverTotal = 0;
                }


            }

            else if (ChestType <= GoldChest + SilverChest + BronzeChest + WoodChest)
            {
                for (int i = 0; i < GoldLoot.Length; i++)
                {
                    goldTotal += GoldLoot[i];

                }
                float goldLootPool = Random.Range(1, goldTotal);

                if (goldLootPool <= GoldChestCommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Common Gold Loot";
                    goldTotal = 0;
                }
                else if (goldLootPool <= GoldChestCommon + GoldChestUncommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Uncommon Gold Loot";
                    goldTotal = 0;
                }
                else if (goldLootPool <= GoldChestCommon + GoldChestUncommon + GoldChestRare)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Rare Gold Loot";
                    goldTotal = 0;
                }
                else if (goldLootPool <= GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Epic Gold Loot";
                    goldTotal = 0;
                }
                else if (goldLootPool <= GoldChestCommon + GoldChestUncommon + GoldChestRare + GoldChestEpic + GoldChestLegendary)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Legendary Gold Loot";
                    goldTotal = 0;
                }

            }

            else if (ChestType <= PlatinumChest + GoldChest + SilverChest + BronzeChest + WoodChest)
            {
                for (int i = 0; i < PlatinumLoot.Length; i++)
                {
                    platinumTotal += PlatinumLoot[i];

                }
                float platinumLootPool = Random.Range(1, platinumTotal);

                if (platinumLootPool <= PlatinumChestCommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Common Platinum Loot";
                    platinumTotal = 0;
                }
                else if (platinumLootPool <= PlatinumChestCommon + PlatinumChestUncommon)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Uncommon Platinum Loot";
                    platinumTotal = 0;
                }
                else if (platinumLootPool <= PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Rare Platinum Loot";
                    platinumTotal = 0;
                }
                else if (platinumLootPool <= PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare + PlatinumChestEpic)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Epic Platinum Loot";
                    platinumTotal = 0;
                }
                else if (platinumLootPool <= PlatinumChestCommon + PlatinumChestUncommon + PlatinumChestRare + PlatinumChestEpic + PlatinumChestLegendary)
                {
                    chestText.SetActive(true);
                    chestText.GetComponent<TextMeshProUGUI>().text = "You got Legendary Platinum Loot";
                    platinumTotal = 0;
                }
            }
        }
    }
}
