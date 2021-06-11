using MySql.Data.MySqlClient;
using System;
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
            int score = Int32.Parse(frags.Text);
            int score_against = Int32.Parse(opponentfrags.Text);
            int damage_hit = Int32.Parse(damage.Text);
            int dmg_taken = Int32.Parse(opponentdamage.Text);
            int healed = Int32.Parse(hphealed.Text);
            int heav = Int32.Parse(heavies.Text);
            int mega = Int32.Parse(megas.Text);
            int light = Int32.Parse(lights.Text);
            int heav_opp = Int32.Parse(opponentheavies.Text);
            int mega_opp = Int32.Parse(opponentmegas.Text);
            int light_opp = Int32.Parse(opponentlights.Text);
            int healed_opp = Int32.Parse(opponenthphealed.Text);
            int mg_fired = Int32.Parse(mgfired.Text);
            int mg_hit = Int32.Parse(mghit.Text);
            int hmg_fired = Int32.Parse(hmgfired.Text);
            int hmg_hit = Int32.Parse(hmghit.Text);
            int sg_fired = Int32.Parse(sgfired.Text);
            int sg_hit = Int32.Parse(sghit.Text);
            int ssg_fired = Int32.Parse(ssgfired.Text);
            int ssg_hit = Int32.Parse(ssghit.Text);
            int rocket_fired = Int32.Parse(rocketfired.Text);
            int rocket_hit = Int32.Parse(rockethit.Text);
            int lg_fired = Int32.Parse(lgfired.Text);
            int lg_hit = Int32.Parse(lghit.Text);
            int rail_fired = Int32.Parse(railfired.Text);
            int rail_hit = Int32.Parse(railhit.Text);
            int rocket_dmg = Int32.Parse(rocketdamage.Text);
            int lg_dmg = Int32.Parse(lgdamage.Text);
            int rail_dmg = Int32.Parse(raildamage.Text);
            float control = 0;
            float total_heavies = heav + heav_opp;
            float total_megas = mega + mega_opp;
            float total_lights = light + light_opp;
            control += (float)((heav / total_heavies) * .4 + (mega / total_megas) * .4 + (light / total_lights) * .2);
            int score_diff = score - score_against;
            string result = "";
            bool won = score > score_against;
            if(score_diff < -3)
            {
                result += "You got handily beaten!\n";
            } else if (score_diff > -3 && score_diff < 4)
            {
                result += "This was a close one!\n";
            } else
            {
                result += "You CLOBBERED them!\n";
            }
            int damage_diff = damage_hit - dmg_taken;
            if (damage_diff < -400)
            {
                result += "You got heavily outdamaged\n";
            }
            else if (damage_diff > -400 && score_diff < 400)
            {
                result += "This was a slug fest, closely matched\n";
            }
            else
            {
                result += "You were hitting like a TRUCK comparatively!\n";
            }
            if(control > .4)
            {
                result += "You had great map control\n";
            } else
            {
                result += "You make your life harder when you don't maintain some kind of control!\n";
            }
            float rocket_acc = rocket_fired/rocket_hit;
            float lg_acc = lg_fired/lg_hit;
            float rail_acc = 0;
            float mg_acc = 0;
            if(rocket_acc > .35)
            {
                result += "You had good rockets\n";
            } else
            {
                result += "Your rockets could use some work\n";
            }
            if(lg_acc > .3)
            {
                result += "You had good lg\n";
            } else
            {
                result += "You need to work on your lg!\n";
            }
            if(rail_fired == 0)
            {
                mg_acc = (mg_fired + hmg_fired) / (mg_hit + hmg_hit);
                if(mg_acc > .35)
                {
                    result += "You had good mg\n";
                } else
                {
                    result += "You need to focus on hitting better mg shots\n";
                }

            } else
            {
                if(rail_acc > .35)
                {
                    result += "Wow, way to hit those rails!\n";
                }
                result += "Rail accuracy like that puts you at a significant disadvantage\n";
            }
            //calc temper
            if(Program.temper == Program.TEMPER.SUPPORTIVE)
            {
                if(won)
                {
                    //do nothing
                    result += "I knew you could do it! Way to go!";
                } else
                {
                    if (feelings.GetItemChecked(0))
                    {
                        Program.temper = Program.TEMPER.HARSH;
                        result += "How could you be happy about that?! Come on!";
                    } else
                    {
                        Program.temper = Program.TEMPER.NEUTRAL;
                        result += "Not what we wanted, but not a major setback.";
                    }
                    
                }
            } else if (Program.temper == Program.TEMPER.NEUTRAL)
            {
                if(won)
                {
                    Program.temper = Program.TEMPER.SUPPORTIVE;
                    result += "Way to turn things around, good stuff!";
                } else
                {
                    if(feelings.GetItemChecked(0))
                    {
                        Program.temper = Program.TEMPER.HARSH;
                        result += "How could you be happy about that?! Come on!";

                    } else if (feelings.GetItemChecked(1))
                    {
                        result += "Good, you should be upset about that performance.";
                    }
                }
            } else
            {
                //stay harsh
                if(won)
                {
                    result += "It's a win, but don't let it go to your head!";
                } else
                {
                    result += "Remember this loss. Let it sting.";
                }
            }
            MessageBox.Show(result);
            this.Close();


        }

       
    }
}
