using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeApp
{
    public partial class PostMatchForm : Form
    {
        string key;
        public PostMatchForm(string key)
        {
            InitializeComponent();
            this.key = key;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update = "UPDATE quakeapp.match SET frags = @frags, opponent_frags = @opponentfrags, damage=@damage, damagetaken=@damagetaken, hphealed=@hphealed, heavies=@heavies, megas=@megas, lights=@lights, opponentheavies=@opponentheavies, opponentmegas=@opponentmegas, opponentlights=@opponentlights, opponenthphealed=@opponenthphealed, mgfired=@mgfired, mghit=@mghit, hmgfired=@hmgfired, hmghit=@hmghit, sgfired=@sgfired, sghit=@sghit, ssgfired=@ssgfired, ssghit=@ssghit, rocketfired=@rocketfired, rockethit=@rockethit, lgfired=@lgfired, lghit=@lghit, railfired=@railfired, railhit=@railhit, mgdamage=@mgdamage, hmgdamage=@hmgdamage, sgdamage=@sgdamage, ssgdamage=@ssgdamage, rocketdamage=@rocketdamage, lgdamage=@lgdamage, raildamage=@raildamage, opponentrocketdamage=@opponentrocketdamage, opponentlgdamage=@opponentlgdamage, opponentraildamage=@opponentraildamage, disappointed=@disappointed, pleased=@pleased, goodrocket=@goodrocket, goodlg=@goodlg, goodrail=@goodrail, goodtiming=@goodtiming, goodfights=@goodfights WHERE timestamp=@timestamp";
            using var cmd = new MySqlCommand(update, Program.db_con);
            cmd.Parameters.AddWithValue("@frags", frags.Text);
            cmd.Parameters.AddWithValue("@opponentfrags", opponentfrags.Text);
            cmd.Parameters.AddWithValue("@damage", damage.Text);
            cmd.Parameters.AddWithValue("@damagetaken", opponentdamage.Text);
            cmd.Parameters.AddWithValue("@hphealed", hphealed.Text);
            cmd.Parameters.AddWithValue("@heavies", heavies.Text);
            cmd.Parameters.AddWithValue("@megas", megas.Text);
            cmd.Parameters.AddWithValue("@lights", lights.Text);
            cmd.Parameters.AddWithValue("@opponentheavies", opponentheavies.Text);
            cmd.Parameters.AddWithValue("@opponentmegas", opponentmegas.Text);
            cmd.Parameters.AddWithValue("@opponentlights", opponentlights.Text);
            cmd.Parameters.AddWithValue("@opponenthphealed", opponenthphealed.Text);
            cmd.Parameters.AddWithValue("@mgfired", mgfired.Text);
            cmd.Parameters.AddWithValue("@mghit", mghit.Text);
            cmd.Parameters.AddWithValue("@hmgfired", hmgfired.Text);
            cmd.Parameters.AddWithValue("@hmghit", hmghit.Text);
            cmd.Parameters.AddWithValue("@sgfired", sgfired.Text);
            cmd.Parameters.AddWithValue("@sghit", sghit.Text);
            cmd.Parameters.AddWithValue("@ssgfired", ssgfired.Text);
            cmd.Parameters.AddWithValue("@ssghit", ssghit.Text);
            cmd.Parameters.AddWithValue("@rocketfired", rocketfired.Text);
            cmd.Parameters.AddWithValue("@rockethit", rockethit.Text);
            cmd.Parameters.AddWithValue("@lgfired", lgfired.Text);
            cmd.Parameters.AddWithValue("@lghit", lghit.Text);
            cmd.Parameters.AddWithValue("@railfired", railfired.Text);
            cmd.Parameters.AddWithValue("@railhit", railhit.Text);
            cmd.Parameters.AddWithValue("@mgdamage", mgdamage.Text);
            cmd.Parameters.AddWithValue("@hmgdamage", hmgdamage.Text);
            cmd.Parameters.AddWithValue("@sgdamage", sgdamage.Text);
            cmd.Parameters.AddWithValue("@ssgdamage", ssgdamage.Text);
            cmd.Parameters.AddWithValue("@rocketdamage", rocketdamage.Text);
            cmd.Parameters.AddWithValue("@lgdamage", lgdamage.Text);
            cmd.Parameters.AddWithValue("@raildamage", raildamage.Text);
            cmd.Parameters.AddWithValue("@opponentrocketdamage", opponentrocketdamage.Text);
            cmd.Parameters.AddWithValue("@opponentlgdamage", opponentlgdamage.Text);
            cmd.Parameters.AddWithValue("@opponentraildamage", opponentraildamage.Text);
            cmd.Parameters.AddWithValue("@pleased", feelings.GetItemChecked(0));
            cmd.Parameters.AddWithValue("@disappointed", feelings.GetItemChecked(1));
            cmd.Parameters.AddWithValue("@goodrail", feelings.GetItemChecked(2));
            cmd.Parameters.AddWithValue("@goodrocket", feelings.GetItemChecked(3));
            cmd.Parameters.AddWithValue("@goodlg", feelings.GetItemChecked(4));
            cmd.Parameters.AddWithValue("@goodtiming", feelings.GetItemChecked(5));
            cmd.Parameters.AddWithValue("@goodfights", feelings.GetItemChecked(6));
            cmd.Parameters.AddWithValue("@timestamp", key);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            //do post match analysis
            this.Close();


        }
    }
}
