using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadBodyLegsGame
{
    public partial class Form1 : Form
    {
        List<string> listOfRandom = new List<string>();
        Random number = new Random();
        int numHead, numBody, numLegs;
        HashSet<int> names = new HashSet<int>();

        public Form1()
        {
            InitializeComponent();
        }

        //Fantasy

        private void cckAnimals_CheckedChanged(object sender, EventArgs e)
        {
            listOfRandom.Add("Dog"); listOfRandom.Add("Cat"); listOfRandom.Add("Horse");
            listOfRandom.Add("Tiger"); listOfRandom.Add("Giraffe"); listOfRandom.Add("Mouse");
            listOfRandom.Add("Raccoon"); listOfRandom.Add("Otter"); listOfRandom.Add("Snake");
            listOfRandom.Add("Rabbit"); listOfRandom.Add("");
        }

        private void cckMythical_CheckedChanged(object sender, EventArgs e)
        {
            listOfRandom.Add("Hydra"); listOfRandom.Add("Dragon"); listOfRandom.Add("Unicron");
            listOfRandom.Add("Fairy"); listOfRandom.Add("Morlok"); listOfRandom.Add("Phoenix");
            listOfRandom.Add("Ogopogo");
        }

        private void btnGenHead_Click(object sender, EventArgs e)
        {
            int listAmount = listOfRandom.Count();

            numHead = number.Next(0, listAmount);
            if (names.Contains(numHead))
            {
                numHead = number.Next(0, listAmount);
            }
            txtHead.Text = listOfRandom[numHead];
        }

        private void btnGenBody_Click(object sender, EventArgs e)
        {
            int listAmount = listOfRandom.Count();

            numBody = number.Next(0, listAmount);
            if (names.Contains(numBody))
            {
                numBody = number.Next(0, listAmount);
            }
            txtBody.Text = listOfRandom[numBody];
        }

        private void btnGenLegs_Click(object sender, EventArgs e)
        {
            int listAmount = listOfRandom.Count();

            numLegs = number.Next(0, listAmount);
            if (names.Contains(numLegs))
            {
                numBody = number.Next(0, listAmount);
            }
            txtLegs.Text = listOfRandom[numLegs];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHead.Clear();
            txtBody.Clear();
            txtLegs.Clear();

            names.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
