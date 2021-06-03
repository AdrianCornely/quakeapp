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
    public partial class StartMatchForm : Form
    {
        public StartMatchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //run pre-match recommendations
            MessageBox.Show(prematch_recommendations());
            //collect and submit current match info
            var sql = "INSERT INTO quakeapp.match (timestamp, opponentname, champion, opponentchampion, map, confident, tired, focused, unsure) VALUES (@timestamp, @opponentname, @champion, @opponentchampion, @map, @confident, @tired, @focused, @unsure)";
            using var cmd = new MySqlCommand(sql, Program.db_con);
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.AddWithValue("@timestamp", timestamp);
            cmd.Parameters.AddWithValue("@opponentname", opponentname.Text);
            cmd.Parameters.AddWithValue("@champion", champion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@opponentchampion", opponentchampion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@map", map.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@confident", feelings.GetItemChecked(0));
            cmd.Parameters.AddWithValue("@tired", feelings.GetItemChecked(1));
            cmd.Parameters.AddWithValue("@focused", feelings.GetItemChecked(2));
            cmd.Parameters.AddWithValue("@unsure", feelings.GetItemChecked(3));
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            //run form for post match results
            PostMatchForm post_form = new PostMatchForm(timestamp);
            post_form.Show();
            this.Close();
        }

        private string prematch_recommendations()
        {
            string result = "First and foremost, good luck and have fun!\n";
            //fetch latest 5 matches, if available
            var latest = "SELECT * FROM quakeapp.match ORDER BY timestamp DESC LIMIT 5";
            using var cmd = new MySqlCommand(latest, Program.db_con);
            using MySqlDataReader reader = cmd.ExecuteReader();
            float win_loss = 0;
            float control = 0;
            int num_records = 0;
            float rocket_acc = 0;
            float lg_acc = 0;
            float rail_acc = 0;
            int num_no_rail = 0;
            while (reader.HasRows && reader.Read())
            {
                num_records++;
                int frags = reader.GetInt32("frags");
                int frags_against = reader.GetInt32("opponent_frags");
                bool won = (frags > frags_against);
                if(won)
                {
                    win_loss++;
                }
                rocket_acc += ((float)reader.GetInt32("rocketfired") / (float)reader.GetInt32("rockethit"));
                lg_acc += ((float)reader.GetInt32("lgfired") / (float)reader.GetInt32("lghit"));
                if(reader.GetString("map").Equals("Corrupted Keep"))
                {
                    num_no_rail++;
                } else
                {
                    rail_acc += ((float)reader.GetInt32("railfired") / (float)reader.GetInt32("railhit"));
                }
                float heavies = (float)reader.GetInt32("heavies");
                float megas = reader.GetFloat("megas");
                float lights = reader.GetFloat("lights");
                float enemy_heavies = reader.GetFloat("opponentheavies");
                float enemy_megas = reader.GetFloat("opponentmegas");
                float enemy_lights = reader.GetFloat("opponentlights");
                float total_heavies = heavies + enemy_heavies;
                float total_megas = megas + enemy_megas;
                float total_lights = lights + enemy_lights;
                control += (float)((heavies / total_heavies) * .4 + (megas / total_megas) * .4 + (lights / total_lights) * .2);
            }
            if(num_records > 0)
            {
                control = control / num_records;
                win_loss = win_loss / num_records;
                rocket_acc = rocket_acc / num_records;
                lg_acc = lg_acc / num_records;
                if (num_no_rail != num_records)
                {
                    rail_acc = rail_acc / (num_records - num_no_rail);
                }
                bool good_control = control > .4;
                bool good_rocket = rocket_acc > .3;
                bool good_lg = lg_acc > .3;
                bool rail_valid = rail_acc != 0;
                bool good_rail = false;
                if(rail_valid)
                {
                    good_rail = rail_acc > .35;
                }
                if(good_control)
                {
                    result += "Your overall control has been decent, so keep up what you're doing!\n";
                } else
                {
                    result += "Your overall control hasn't been great, so you keep getting outstacked. Try working on your timings and positioning around the major items!\n";
                }
                if(good_rocket)
                {
                    result += "Your rockets have been hitting decently, so keep doing what you're doing in mid/close range with them!\n";
                } else
                {
                    result += "Your rockets haven't been doing much, try to focus on better rocket placement this game!\n";
                }
                if(rail_valid)
                {
                    if(good_rail)
                    {
                        result += "Your rail has been solid, keep holding those angles and hitting those shots!\n";
                    } else
                    {
                        result += "Your rail has been off, try to position better and anticipate where they'll be!\n";
                    }
                }
                if(good_lg)
                {
                    result += "Your LG has been good, let's keep it up!\n";
                } else
                {
                    result += "Your LG hasn't been great, try to focus on using your strafing to aim instead of your mouse!\n";
                }
                if(win_loss > .8)
                {
                    result += "You've been on a hot streak, keep it up!\n";
                } else if (win_loss < .8 && win_loss > .4)
                {
                    result += "You've been doing fine lately, so relax and do what you need to do!\n";
                } else
                {
                    result += "I know you've been on a rut lately, but that's okay! Take it one game at a time and work on your fundamentals!\n";
                }
                return result;
            } else
            {
                result += "I don't have any data to assist you, but I believe in you!\n";
                return result;
            }
        }
    }
}
