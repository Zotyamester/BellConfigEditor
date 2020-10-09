using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace BellConfigEditor
{
    public partial class ConfigEditor : Form
    {
        private List<Bell> bells;
        private List<Timestamp> currentTimestamps;
        private string selectedfile = "";

        public ConfigEditor()
        {
            InitializeComponent();
            bells = new List<Bell>();
            currentTimestamps = new List<Timestamp>();
        }

        private void LoadRings(string filename)
        {
            bells.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                Bell bell = new Bell();
                string soundfile = node.ChildNodes[0].InnerText;
                Days days = new Days();
                days.mo = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[0].Value));
                days.tu = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[1].Value));
                days.we = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[2].Value));
                days.th = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[3].Value));
                days.fr = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[4].Value));
                days.sa = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[5].Value));
                days.su = Convert.ToBoolean(int.Parse(node.ChildNodes[1].Attributes[6].Value));
                List<Timestamp> timestamps = new List<Timestamp>();
                for (int i = 2; i < node.ChildNodes.Count; i++)
                {
                    Timestamp timestamp = new Timestamp();
                    timestamp.hour = int.Parse(node.ChildNodes[i].Attributes[0].Value);
                    timestamp.minute = int.Parse(node.ChildNodes[i].Attributes[1].Value);
                    timestamp.second = int.Parse(node.ChildNodes[i].Attributes[2].Value);
                    timestamps.Add(timestamp);
                }
                bell.soundfile = soundfile;
                bell.days = days;
                bell.timestamps = timestamps;
                bells.Add(bell);
                lvRules.Items.Add(bell.ToString());
            }
        }

        private void ClearFields()
        {
            selectedfile = "";
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            currentTimestamps = new List<Timestamp>();
        }

        private void SaveRings(string filename)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode bellNode = xmlDoc.CreateElement("bell");

            bells.Sort();
            foreach (Bell r in bells)
            {
                XmlNode ringNode = xmlDoc.CreateElement("ring");

                XmlNode mediaNode = xmlDoc.CreateElement("media");

                mediaNode.InnerText = r.soundfile;

                ringNode.AppendChild(mediaNode);

                XmlNode daysNode = xmlDoc.CreateElement("days");

                XmlAttribute mo = xmlDoc.CreateAttribute("mo");
                mo.Value = Convert.ToInt32(r.days.mo).ToString();
                daysNode.Attributes.Append(mo);
                XmlAttribute tu = xmlDoc.CreateAttribute("tu");
                tu.Value = Convert.ToInt32(r.days.tu).ToString();
                daysNode.Attributes.Append(tu);
                XmlAttribute we = xmlDoc.CreateAttribute("we");
                we.Value = Convert.ToInt32(r.days.we).ToString();
                daysNode.Attributes.Append(we);
                XmlAttribute th = xmlDoc.CreateAttribute("th");
                th.Value = Convert.ToInt32(r.days.th).ToString();
                daysNode.Attributes.Append(th);
                XmlAttribute fr = xmlDoc.CreateAttribute("fr");
                fr.Value = Convert.ToInt32(r.days.fr).ToString();
                daysNode.Attributes.Append(fr);
                XmlAttribute sa = xmlDoc.CreateAttribute("sa");
                sa.Value = Convert.ToInt32(r.days.sa).ToString();
                daysNode.Attributes.Append(sa);
                XmlAttribute su = xmlDoc.CreateAttribute("su");
                su.Value = Convert.ToInt32(r.days.su).ToString();
                daysNode.Attributes.Append(su);

                ringNode.AppendChild(daysNode);

                foreach (Timestamp timestamp in r.timestamps)
                {
                    XmlNode timeNode = xmlDoc.CreateElement("time");

                    XmlAttribute hour = xmlDoc.CreateAttribute("h");
                    hour.Value = timestamp.hour.ToString();
                    timeNode.Attributes.Append(hour);
                    XmlAttribute minute = xmlDoc.CreateAttribute("m");
                    minute.Value = timestamp.minute.ToString();
                    timeNode.Attributes.Append(minute);
                    XmlAttribute second = xmlDoc.CreateAttribute("s");
                    second.Value = timestamp.second.ToString();
                    timeNode.Attributes.Append(second);

                    ringNode.AppendChild(timeNode);
                }

                bellNode.AppendChild(ringNode);
            }

            xmlDoc.AppendChild(bellNode);
            xmlDoc.Save(filename);
        }

        private void bOpenConfig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    LoadRings(filename);
                }
            }
        }

        private void bNewRule_Click(object sender, EventArgs e)
        {
            Bell r = new Bell();
            string soundfile = selectedfile;
            Days days = new Days();
            days.mo = chkMonday.Checked;
            days.tu = chkTuesday.Checked;
            days.we = chkWednesday.Checked;
            days.th = chkThursday.Checked;
            days.fr = chkFriday.Checked;
            days.sa = chkSaturday.Checked;
            days.su = chkSunday.Checked;
            r.soundfile = soundfile;
            r.days = days;
            r.timestamps = currentTimestamps;
            bells.Add(r);
            lvRules.Items.Add(r.ToString());
            ClearFields();
        }

        private void SetFields(Bell r)
        {
            ClearFields();
            selectedfile = r.soundfile;
            chkMonday.Checked = r.days.mo;
            chkTuesday.Checked = r.days.tu;
            chkWednesday.Checked = r.days.we;
            chkThursday.Checked = r.days.th;
            chkFriday.Checked = r.days.fr;
            chkSaturday.Checked = r.days.sa;
            chkSunday.Checked = r.days.su;
            currentTimestamps = r.timestamps;
        }

        private void bDeleteRule_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedfile = Path.GetFileName(openFileDialog.FileName);
                }
            }
        }

        private void bNewConfig_Click(object sender, EventArgs e)
        {
            ClearFields();
            bells = new List<Bell>();
            lvRules.Clear();
        }

        private void bSaveConfig_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveRings(saveFileDialog.FileName);
                    MessageBox.Show("Mentve!");
                }
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            using (TimeEditor form2 = new TimeEditor(currentTimestamps))
            {
                form2.ShowDialog();
            }
        }

        private void lvRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count == 0)
                return;
            Bell r = bells[lvRules.SelectedItems[0].Index];
            bells.RemoveAt(lvRules.SelectedItems[0].Index);
            lvRules.Items.RemoveAt(lvRules.SelectedItems[0].Index);
            SetFields(r);
        }
    }
}
