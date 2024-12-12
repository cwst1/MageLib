using MageLib;
using System;

namespace Mage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGuildData();
        }

        private void LoadGuildData()
        {
            // Dodaj przyk³adowych magów
            guild.AddMage(new Mag
            {
                Name = "Gandalf",
                Level = 5,
                Intelligence = 30,
                Dexterity = 15,
                MaxMana = 100,
                SpellBook = new SpellBook
            {
                new Spell { Name = "Fireball", Type = SpellType.Offensive, ManaCost = 20, Effect = 100 },
                new Spell { Name = "Shield", Type = SpellType.Defensive, ManaCost = 10, Effect = 50 }
            }
            });
            guild.AddMage(new Mage
            {
                Name = "Merlin",
                Level = 8,
                Intelligence = 25,
                Dexterity = 12,
                MaxMana = 80,
                SpellBook = new SpellBook
            {
                new Spell { Name = "Heal", Type = SpellType.Healing, ManaCost = 15, Effect = 50 },
                new Spell { Name = "Magic Missile", Type = SpellType.Offensive, ManaCost = 10, Effect = 30 }
            }
            });
            // Dodaj wiêcej magów, jeœli potrzebujesz
        }

        private void btnGetAllMages_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            foreach (var mage in guild.GetAllMages())
            {
                listBoxResults.Items.Add(mage.ToString());
                listBoxResults.Items.Add(""); // Dodanie pustej linii
            }
        }

        private void btnGetExperiencedMages_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            int level = int.Parse(txtLevel.Text);
            foreach (var mage in guild.GetExperiencedMages(level))
            {
                listBoxResults.Items.Add(mage.ToString());
                listBoxResults.Items.Add("");
            }
        }

        private void btnGetTalentedMages_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            int maxLevel = int.Parse(txtMaxLevel.Text);
            foreach (var mage in guild.GetTalentedMages(maxLevel))
            {
                listBoxResults.Items.Add(mage.ToString());
                listBoxResults.Items.Add("");
            }
        }

        private void btnGetTotalBattlePotential_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            int totalMana = guild.GetTotalBattlePotential();
            listBoxResults.Items.Add($"Total Battle Potential (Mana): {totalMana}");
        }

        private void btnGetMagesWithArsenal_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            int minSpells = int.Parse(txtMinSpells.Text);
            foreach (var mage in guild.GetMagesWithArsenal(minSpells))
            {
                listBoxResults.Items.Add($"Name: {mage.Name}, Spells: {mage.SpellCount}, Mana: {mage.Mana}");
                listBoxResults.Items.Add("");
            }
        }

        private void btnGetVersatileMages_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            foreach (var mage in guild.GetVersatileMages())
            {
                listBoxResults.Items.Add($"Name: {mage.Name}, Level: {mage.Level}, Average Attributes: {mage.AverageAttribute:F2}");
                listBoxResults.Items.Add("");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
