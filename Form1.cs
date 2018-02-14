using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        Composite armyLoadout;
        Composite longHikeLoadout;
        Composite shortHikeLoadout;

        Composite armyRuckSack;
        Composite civyRuckSack;
        
        Composite m4a1;
        Leaf acog;
        Leaf frontGrip;
        Leaf acu;
        Composite feildLoadCarrier;
        Composite bandolier;
        Composite armyHelmet;
        Leaf nightVision;
        Leaf rhinoMount;
        Leaf camoHelmetCover;
        Leaf ceramicDomeCap;
        
        Composite backpack;

        Leaf combatBoots;
        Leaf paracord;
        
        Composite camelback;
        Composite magazine;
        Leaf water;
        Leaf waterCarrier;
        Leaf ammo;
        Leaf foldableShovel;

        Composite mre;
        Leaf powderedEggs;
        Leaf porccessedMeat;
        Leaf survivalBar;
        Leaf rubberBag;

        Leaf hat;
        Leaf shirt;
        Leaf pants;
        Leaf undergarments;
        Leaf pancho;
        Leaf tentStake;

        Leaf multitool;

        int currentLoadout;

        public Form1()
        {
            InitializeComponent();
            InitializeCompositePattern();
            CreateCamelback();
            CreateArmyLoadout();
            CreateLongHikeLoadout();
            CreateShortHikeLoadout();
            
            currentLoadout = 0;
        }

        private void CreateCamelback()
        {
            camelback.Add(water);
        }

        private void InitializeCompositePattern()
        {
            armyLoadout = new Composite("Army Loadout", 0);
            shortHikeLoadout = new Composite("Short Hike Loadout", 0);
            longHikeLoadout = new Composite("Long Hike Loadout", 0);

            m4a1 = new Composite("M4A1", 9);
            acog = new Leaf("ACOG", 2);
            frontGrip = new Leaf("Front Grip", 1);
            magazine = new Composite("Magazine", 1);
            ammo = new Leaf("NATO 5.56 ", 0.1);

            armyRuckSack = new Composite("Ruck Sack", 3);
            civyRuckSack = new Composite("Ruck Sack", 3);
            backpack = new Composite("Backpack", 1);

            mre = new Composite("MRE", 0);
            powderedEggs = new Leaf("Powdered Eggs", 0.3);
            porccessedMeat = new Leaf("Meat", 0.3);
            survivalBar = new Leaf("Energy Bar", 0.2);
            rubberBag = new Leaf("MRE Bag", 0.1);

            acu = new Leaf("ACU", 2);
            undergarments = new Leaf("Undergarments", 1);
            combatBoots = new Leaf("Combat Boots", 3);
            feildLoadCarrier = new Composite("FLC", 1);
            bandolier = new Composite("Banolier", 0.5);
            hat = new Leaf("Hat", 0.3);
            shirt = new Leaf("Shirt", 1);
            pants = new Leaf("Pants", 1);

            foldableShovel = new Leaf("Foldable Shovel", 2);
            pancho = new Leaf("Pancho", 1);
            tentStake = new Leaf("Red Tent Stake", 0.3);
            paracord = new Leaf("550 cord", 2);
            
            armyHelmet = new Composite("ACH", 0);
            nightVision = new Leaf("NVG", 1);
            rhinoMount = new Leaf("Rhino Mount", 0.3);
            camoHelmetCover = new Leaf("Helmet Cover", 0.1);
            ceramicDomeCap = new Leaf("Ceramic Combat Helmet", 5);

            multitool = new Leaf("Gerber", 1);
            camelback = new Composite("Camelback", 0);
            waterCarrier = new Leaf("Water Container", 1);
            water = new Leaf("Water", 8.2);
        }

        private void CreateShortHikeLoadout()
        {
            CreateBackpack();
            shortHikeLoadout.Add(backpack);
            shortHikeLoadout.Add(undergarments);
            shortHikeLoadout.Add(pants);
            shortHikeLoadout.Add(shirt);
            shortHikeLoadout.Add(combatBoots);
            shortHikeLoadout.Add(multitool);
        }

        private void CreateBackpack()
        {
            backpack.Add(camelback);
            backpack.Add(survivalBar);
        }

        private void CreateLongHikeLoadout()
        {
            CreateCivyRucksack();
            longHikeLoadout.Add(undergarments);
            longHikeLoadout.Add(pants);
            longHikeLoadout.Add(shirt);
            longHikeLoadout.Add(hat);
            longHikeLoadout.Add(combatBoots);
            longHikeLoadout.Add(civyRuckSack);
            longHikeLoadout.Add(multitool);
        }

        private void CreateCivyRucksack()
        {
            civyRuckSack.Add(mre);
            civyRuckSack.Add(mre);
            civyRuckSack.Add(camelback);
            civyRuckSack.Add(pancho);
            civyRuckSack.Add(paracord);
            for (int i = 0; i < 6; i++)
            {
                civyRuckSack.Add(tentStake);
            }
            civyRuckSack.Add(combatBoots);
            civyRuckSack.Add(pants);
            civyRuckSack.Add(shirt);
            civyRuckSack.Add(undergarments);
        }

        private void CreateArmyLoadout()
        {
            CreateArmyHelmet();
            CreateM4A1();
            CreateArmyRuckSack();
            CreateFeildLoadCarrier();

            armyLoadout.Add(armyHelmet);
            armyLoadout.Add(m4a1);
            armyLoadout.Add(armyRuckSack);
            armyLoadout.Add(feildLoadCarrier);
            armyLoadout.Add(acu);
            armyLoadout.Add(undergarments);
            armyLoadout.Add(combatBoots);
            armyLoadout.Add(multitool);
            armyLoadout.Add(camelback);
        }

        private void CreateFeildLoadCarrier()
        {
            for (int i = 0; i < 8; i++)
            {
                bandolier.Add(magazine);
            }
            feildLoadCarrier.Add(bandolier);
            feildLoadCarrier.Add(multitool);
        }

        private void CreateArmyRuckSack()
        {
            CreateMRE();

            armyRuckSack.Add(paracord);
            armyRuckSack.Add(pancho);
            for (int i = 0; i < 6; i++)
            {
                armyRuckSack.Add(tentStake);
            }
            armyRuckSack.Add(acu);
            armyRuckSack.Add(undergarments);
            armyRuckSack.Add(combatBoots);
            armyRuckSack.Add(mre);
            armyRuckSack.Add(mre);
        }

        private void CreateMRE()
        {
            mre.Add(powderedEggs);
            mre.Add(porccessedMeat);
            mre.Add(survivalBar);
            mre.Add(rubberBag);
        }

        private void CreateMagazine()
        {
            magazine.Add(ammo);
        }

        private void CreateM4A1()
        {
            CreateMagazine();

            m4a1.Add(acog);
            m4a1.Add(frontGrip);
            m4a1.Add(magazine);
        }

        private void CreateArmyHelmet()
        {
            armyHelmet.Add(ceramicDomeCap);
            armyHelmet.Add(camoHelmetCover);
            armyHelmet.Add(rhinoMount);
            armyHelmet.Add(nightVision);
        }

        private void btn_shortHike_Click(object sender, EventArgs e)
        {
            txtBox_display.Text = shortHikeLoadout.ToString(0);
            lbl_weight.Text = shortHikeLoadout.CalculateWeight() + "";
            currentLoadout = 1;
        }

        private void btn_longHike_Click(object sender, EventArgs e)
        {
            txtBox_display.Text = longHikeLoadout.ToString(0);
            lbl_weight.Text = longHikeLoadout.CalculateWeight() + "";
            currentLoadout = 2;
        }

        private void btn_army_Click(object sender, EventArgs e)
        {
            txtBox_display.Text = armyLoadout.ToString(0);
            lbl_weight.Text = armyLoadout.CalculateWeight() + "";
            currentLoadout = 3;
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            Component tmp;
            string tmpStr;

            switch (cmb_item.SelectedIndex)
            {
                case 0:
                    tmp = water;
                    break;
                case 1:
                    tmp = survivalBar;
                    break;
                default:
                    tmp = tentStake;
                    break;
            }

            switch (currentLoadout)
            {
                case 1:
                    backpack.Add(tmp);
                    tmpStr = shortHikeLoadout.ToString(0);
                    lbl_weight.Text = shortHikeLoadout.CalculateWeight() + "";
                    break;
                case 2:
                    civyRuckSack.Add(tmp);
                    tmpStr = longHikeLoadout.ToString(0);
                    lbl_weight.Text = longHikeLoadout.CalculateWeight() + "";
                    break;
                default:
                    armyRuckSack.Add(tmp);
                    tmpStr = armyLoadout.ToString(0);
                    lbl_weight.Text = armyLoadout.CalculateWeight() + "";
                    break;
            }

            txtBox_display.Text = tmpStr;
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            Component tmp;
            string tmpStr;

            switch (cmb_item.SelectedIndex)
            {
                case 0:
                    tmp = water;
                    break;
                case 1:
                    tmp = survivalBar;
                    break;
                default:
                    tmp = tentStake;
                    break;
            }

            switch (currentLoadout)
            {
                case 1:
                    backpack.Remove(tmp);
                    tmpStr = shortHikeLoadout.ToString(0);
                    lbl_weight.Text = shortHikeLoadout.CalculateWeight() + "";
                    break;
                case 2:
                    civyRuckSack.Remove(tmp);
                    tmpStr = longHikeLoadout.ToString(0);
                    lbl_weight.Text = longHikeLoadout.CalculateWeight() + "";
                    break;
                default:
                    armyRuckSack.Remove(tmp);
                    tmpStr = armyLoadout.ToString(0);
                    lbl_weight.Text = armyLoadout.CalculateWeight() + "";
                    break;
            }

            txtBox_display.Text = tmpStr;
        }
    }
}
