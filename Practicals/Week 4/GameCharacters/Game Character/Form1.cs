using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        //Declare a list of characters
        List<Character> charList = new List<Character>();

        public Form1()
        {
            InitializeComponent();
            charList.Add(new Bandit("Mild-Mannered Pate"));
            charList.Add(new Sorceror("Yuria the Witch"));
            charList.Add(new Bandit("Creighton the Wanderer"));
            charList.Add(new Cleric("Allfather Lloyd"));
            charList.Add(new Knight("Seigmeyer of Catarina"));
            updateForm();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //Create a new character
            addNewCharacter();

            //Update forms to reflect newly created character
            updateForm();
        }

        //Method used to Update the listboxes on the form
        public void updateForm()
        {
            //Clear checklistBoxes to prevent duplication.
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            //Update relevant listboxes on the form so they display current information
            foreach (Character c in charList)
            {
                //Re-add characters to the boxes.
                checkedListBox1.Items.Add(c.characterName);
                checkedListBox2.Items.Add(c.characterName);
            }
        }

        public void addNewCharacter()
        {
            //Begin creating a character
            Character newCharacter;

            //Create a different class depending on the checked rdo button.
            //Then adds the character to checklists on the form.
            if (rdKnight.Checked == true)
            {
                newCharacter = new Knight(txtName.Text);
                charList.Add(newCharacter);
            }
            else if (rdBandit.Checked == true)
            {
                newCharacter = new Bandit(txtName.Text);
                charList.Add(newCharacter);
            }
            else if (rdCleric.Checked == true)
            {
                newCharacter = new Bandit(txtName.Text);
                charList.Add(newCharacter);
            }
            else if (rdSorc.Checked == true)
            {
                newCharacter = new Knight(txtName.Text);
                charList.Add(newCharacter);
            }
            else
            {
                MessageBox.Show("You have not selected a Character class.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Run the changeWeapon method when button clicked
            changeWeapons();
        }

        //Method to retrieve a list of all checked characters and swap their weapon to the selected choice
        public void changeWeapons()
        {
            //Retrieve checked items in the listbox
            foreach (int checkedIndex in checkedListBox2.CheckedIndices)
            {
                //Determine which rdobutton has been checked
                if (rdSword.Checked == true)
                {
                    charList[checkedIndex].weapon = new sword();
                }
                else if (rdMace.Checked == true)
                {
                    charList[checkedIndex].weapon = new mace();
                }
                else if (rdSpear.Checked == true)
                {
                    charList[checkedIndex].weapon = new spear();
                }
                else
                {
                    MessageBox.Show("You haven't selected a weapon.");
                }
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            //Calls the battle method
            battle();
        }

        //Battle() sets up the combatants and determines them before passing to another method which writes out the combatants strings.
        public void battle()
        {
            //Combatant indices
            int combatant1 = 0;
            int combatant2 = 0;

            //Setup iterator to determine which combatant to add where
            int iterator = 0;

            //Determine which checkboxes are selected (crashes if more than 2 selected)
            foreach (int checkedIndex in checkedListBox1.CheckedIndices)
            {
                //If iterator has yet to increase, assign that indice as the first combatant.
                if (iterator == 0)
                {
                    combatant1 = checkedIndex;
                    iterator++;
                }
                else
                {
                    combatant2 = checkedIndex;
                }
            }

            //Generate the battlestrings in another method
            battleStrings(combatant1, combatant2);
            
        }

        public void battleStrings(int combatant1, int combatant2)
        {
            //Clear the listbox before putting more content in
            listBox1.Items.Clear();

            //Output combatant1's strings
            listBox1.Items.Add(charList[combatant1].outputName());
            listBox1.Items.Add(charList[combatant1].outputType());
            listBox1.Items.Add(charList[combatant1].useCharactersWeapon());

            //Divider for clarity
            listBox1.Items.Add("************************");

            //Output combatant2's strings
            listBox1.Items.Add(charList[combatant2].outputName());
            listBox1.Items.Add(charList[combatant2].outputType());
            listBox1.Items.Add(charList[combatant2].useCharactersWeapon());
        }
    }
}
