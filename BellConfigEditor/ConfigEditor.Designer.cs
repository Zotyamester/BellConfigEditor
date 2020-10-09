using System.Collections.Generic;

namespace BellConfigEditor
{
    public partial class ConfigEditor
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
            this.bOpenConfig = new System.Windows.Forms.Button();
            this.bNewConfig = new System.Windows.Forms.Button();
            this.bSaveConfig = new System.Windows.Forms.Button();
            this.lvRules = new System.Windows.Forms.ListView();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.lSoundfile = new System.Windows.Forms.Label();
            this.bNewRule = new System.Windows.Forms.Button();
            this.bDeleteRule = new System.Windows.Forms.Button();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.lTimestamps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOpenConfig
            // 
            this.bOpenConfig.Location = new System.Drawing.Point(12, 41);
            this.bOpenConfig.Name = "bOpenConfig";
            this.bOpenConfig.Size = new System.Drawing.Size(75, 23);
            this.bOpenConfig.TabIndex = 1;
            this.bOpenConfig.Text = "Megnyitás";
            this.bOpenConfig.UseVisualStyleBackColor = true;
            this.bOpenConfig.Click += new System.EventHandler(this.bOpenConfig_Click);
            // 
            // bNewConfig
            // 
            this.bNewConfig.Location = new System.Drawing.Point(12, 12);
            this.bNewConfig.Name = "bNewConfig";
            this.bNewConfig.Size = new System.Drawing.Size(75, 23);
            this.bNewConfig.TabIndex = 0;
            this.bNewConfig.Text = "Új";
            this.bNewConfig.UseVisualStyleBackColor = true;
            this.bNewConfig.Click += new System.EventHandler(this.bNewConfig_Click);
            // 
            // bSaveConfig
            // 
            this.bSaveConfig.Location = new System.Drawing.Point(12, 70);
            this.bSaveConfig.Name = "bSaveConfig";
            this.bSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.bSaveConfig.TabIndex = 2;
            this.bSaveConfig.Text = "Mentés";
            this.bSaveConfig.UseVisualStyleBackColor = true;
            this.bSaveConfig.Click += new System.EventHandler(this.bSaveConfig_Click);
            // 
            // lvRules
            // 
            this.lvRules.HideSelection = false;
            this.lvRules.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvRules.Location = new System.Drawing.Point(225, 84);
            this.lvRules.MultiSelect = false;
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(441, 211);
            this.lvRules.TabIndex = 14;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.SelectedIndexChanged += new System.EventHandler(this.lvRules_SelectedIndexChanged);
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(225, 47);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(52, 17);
            this.chkMonday.TabIndex = 7;
            this.chkMonday.Text = "Hétfő";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(533, 47);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(67, 17);
            this.chkSaturday.TabIndex = 12;
            this.chkSaturday.Text = "Szombat";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(472, 47);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(60, 17);
            this.chkFriday.TabIndex = 11;
            this.chkFriday.Text = "Péntek";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(398, 47);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(71, 17);
            this.chkThursday.TabIndex = 10;
            this.chkThursday.Text = "Csütörtök";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(335, 47);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(59, 17);
            this.chkWednesday.TabIndex = 9;
            this.chkWednesday.Text = "Szerda";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(279, 47);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(51, 17);
            this.chkTuesday.TabIndex = 8;
            this.chkTuesday.Text = "Kedd";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(279, 12);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 5;
            this.bSelect.Text = "Kiválasztás";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // lSoundfile
            // 
            this.lSoundfile.AutoSize = true;
            this.lSoundfile.Location = new System.Drawing.Point(222, 17);
            this.lSoundfile.Name = "lSoundfile";
            this.lSoundfile.Size = new System.Drawing.Size(49, 13);
            this.lSoundfile.TabIndex = 16;
            this.lSoundfile.Text = "Hangfájl:";
            // 
            // bNewRule
            // 
            this.bNewRule.Location = new System.Drawing.Point(119, 12);
            this.bNewRule.Name = "bNewRule";
            this.bNewRule.Size = new System.Drawing.Size(75, 23);
            this.bNewRule.TabIndex = 3;
            this.bNewRule.Text = "Új";
            this.bNewRule.UseVisualStyleBackColor = true;
            this.bNewRule.Click += new System.EventHandler(this.bNewRule_Click);
            // 
            // bDeleteRule
            // 
            this.bDeleteRule.Location = new System.Drawing.Point(119, 41);
            this.bDeleteRule.Name = "bDeleteRule";
            this.bDeleteRule.Size = new System.Drawing.Size(75, 23);
            this.bDeleteRule.TabIndex = 4;
            this.bDeleteRule.Text = "Törlés";
            this.bDeleteRule.UseVisualStyleBackColor = true;
            this.bDeleteRule.Click += new System.EventHandler(this.bDeleteRule_Click);
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Location = new System.Drawing.Point(606, 47);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(71, 17);
            this.chkSunday.TabIndex = 13;
            this.chkSunday.Text = "Vasárnap";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(457, 12);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "Szerkesztés";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lTimestamps
            // 
            this.lTimestamps.AutoSize = true;
            this.lTimestamps.Location = new System.Drawing.Point(395, 17);
            this.lTimestamps.Name = "lTimestamps";
            this.lTimestamps.Size = new System.Drawing.Size(58, 13);
            this.lTimestamps.TabIndex = 23;
            this.lTimestamps.Text = "Időpontok:";
            // 
            // ConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 307);
            this.Controls.Add(this.lTimestamps);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.chkSunday);
            this.Controls.Add(this.bDeleteRule);
            this.Controls.Add(this.bNewRule);
            this.Controls.Add(this.lSoundfile);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.chkTuesday);
            this.Controls.Add(this.chkWednesday);
            this.Controls.Add(this.chkThursday);
            this.Controls.Add(this.chkFriday);
            this.Controls.Add(this.chkSaturday);
            this.Controls.Add(this.chkMonday);
            this.Controls.Add(this.lvRules);
            this.Controls.Add(this.bSaveConfig);
            this.Controls.Add(this.bNewConfig);
            this.Controls.Add(this.bOpenConfig);
            this.Name = "ConfigEditor";
            this.Text = "Csengőszerkesztő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpenConfig;
        private System.Windows.Forms.Button bNewConfig;
        private System.Windows.Forms.Button bSaveConfig;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Label lSoundfile;
        private System.Windows.Forms.Button bNewRule;
        private System.Windows.Forms.Button bDeleteRule;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lTimestamps;
    }
}