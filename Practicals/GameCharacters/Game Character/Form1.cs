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

        //Add some dummy characters

        //Update the lists at init

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This button is just for debugging simple stuff and will be removed later.

            Character tootie = new Knight("Seigmeyer of Catarina");
            listBox2.Items.Add(tootie.outputName());
            listBox2.Items.Add(tootie.outputType());
            listBox2.Items.Add(tootie.useCharactersWeapon());

            Character frooty = new Bandit("Mild-Mannered Pate");
            listBox2.Items.Add(frooty.outputName());
            listBox2.Items.Add(frooty.outputType());
            listBox2.Items.Add(frooty.useCharactersWeapon());

            //output an item from the list
            listBox2.Items.Add(charList[0].useCharactersWeapon());
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
            foreach (Character checkedChar in checkedListBox2.CheckedItems)
            {
                //Determine which rdobutton has been checked
                if (rdSword.Checked == true)
                {
                    checkedChar.weapon = new sword();
                }
                else if (rdMace.Checked == true)
                {
                    checkedChar.weapon = new mace();
                }
                else if (rdMace.Checked == true)
                {
                    checkedChar.weapon = new spear();
                }
                else
                {
                    MessageBox.Show("You haven't selected a weapon.");
                }
            }
        }
    }
}
