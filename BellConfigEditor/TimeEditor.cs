using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BellConfigEditor
{
    public partial class Form2 : Form
    {
        public static List<Timestamp> timestamps;

        public Form2(List<Timestamp> timestamps)
        {
            InitializeComponent();
            Form2.timestamps = timestamps;
            lvTimestamps.Clear();
            foreach (Timestamp timestamp in timestamps)
            {
                lvTimestamps.Items.Add(timestamp.Repr());
            }
        }

        private void SetFields(Timestamp t)
        {
            tbHour.Text = t.hour.ToString();
            tbMinute.Text = t.minute.ToString();
            tbSecond.Text = t.second.ToString();
        }

        private void ClearFields()
        {
            tbHour.Text = "0";
            tbMinute.Text = "0";
            tbSecond.Text = "0";
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Timestamp timestamp = new Timestamp();
            timestamp.hour = int.Parse(tbHour.Text);
            timestamp.minute = int.Parse(tbMinute.Text);
            timestamp.second = int.Parse(tbSecond.Text);
            timestamps.Add(timestamp);
            lvTimestamps.Items.Add(timestamp.Repr());
            ClearFields();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvTimestamps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTimestamps.SelectedItems.Count == 0)
                return;
            Timestamp t = timestamps[lvTimestamps.SelectedItems[0].Index];
            timestamps.RemoveAt(lvTimestamps.SelectedItems[0].Index);
            lvTimestamps.Items.RemoveAt(lvTimestamps.SelectedItems[0].Index);
            SetFields(t);
        }
    }
}
