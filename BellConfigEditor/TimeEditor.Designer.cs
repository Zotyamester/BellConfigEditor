namespace BellConfigEditor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.lvTimestamps = new System.Windows.Forms.ListView();
            this.bClose = new System.Windows.Forms.Button();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.lHour = new System.Windows.Forms.Label();
            this.lMinute = new System.Windows.Forms.Label();
            this.lSecond = new System.Windows.Forms.Label();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(12, 41);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Törlés";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(12, 12);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 0;
            this.bNew.Text = "Új";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // lvTimestamps
            // 
            this.lvTimestamps.HideSelection = false;
            this.lvTimestamps.Location = new System.Drawing.Point(12, 70);
            this.lvTimestamps.MultiSelect = false;
            this.lvTimestamps.Name = "lvTimestamps";
            this.lvTimestamps.Size = new System.Drawing.Size(460, 229);
            this.lvTimestamps.TabIndex = 5;
            this.lvTimestamps.UseCompatibleStateImageBehavior = false;
            this.lvTimestamps.SelectedIndexChanged += new System.EventHandler(this.lvTimestamps_SelectedIndexChanged);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(397, 305);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 6;
            this.bClose.Text = "Bezárás";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(169, 28);
            this.tbHour.MaxLength = 2;
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(49, 20);
            this.tbHour.TabIndex = 2;
            this.tbHour.Text = "0";
            // 
            // lHour
            // 
            this.lHour.AutoSize = true;
            this.lHour.Location = new System.Drawing.Point(128, 31);
            this.lHour.Name = "lHour";
            this.lHour.Size = new System.Drawing.Size(27, 13);
            this.lHour.TabIndex = 26;
            this.lHour.Text = "Óra:";
            // 
            // lMinute
            // 
            this.lMinute.AutoSize = true;
            this.lMinute.Location = new System.Drawing.Point(243, 31);
            this.lMinute.Name = "lMinute";
            this.lMinute.Size = new System.Drawing.Size(32, 13);
            this.lMinute.TabIndex = 27;
            this.lMinute.Text = "Perc:";
            // 
            // lSecond
            // 
            this.lSecond.AutoSize = true;
            this.lSecond.Location = new System.Drawing.Point(354, 31);
            this.lSecond.Name = "lSecond";
            this.lSecond.Size = new System.Drawing.Size(63, 13);
            this.lSecond.TabIndex = 28;
            this.lSecond.Text = "Másodperc:";
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(281, 28);
            this.tbMinute.MaxLength = 2;
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(49, 20);
            this.tbMinute.TabIndex = 3;
            this.tbMinute.Text = "0";
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(423, 28);
            this.tbSecond.MaxLength = 2;
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(49, 20);
            this.tbSecond.TabIndex = 4;
            this.tbSecond.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.lSecond);
            this.Controls.Add(this.lMinute);
            this.Controls.Add(this.lHour);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lvTimestamps);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Name = "Form2";
            this.Text = "Időpontszerkesztő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.ListView lvTimestamps;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label lHour;
        private System.Windows.Forms.Label lMinute;
        private System.Windows.Forms.Label lSecond;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.TextBox tbSecond;
    }
}