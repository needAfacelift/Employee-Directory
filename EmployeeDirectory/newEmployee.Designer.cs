namespace EmployeeDirectory
{
    partial class newEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newEmployee));
            this.txt_First = new System.Windows.Forms.TextBox();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_First = new System.Windows.Forms.Label();
            this.lbl_Last = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(53, 79);
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(200, 20);
            this.txt_First.TabIndex = 0;
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(259, 79);
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(200, 20);
            this.txt_Last.TabIndex = 1;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(465, 79);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(200, 20);
            this.txt_Title.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(53, 125);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_First
            // 
            this.lbl_First.AutoSize = true;
            this.lbl_First.Location = new System.Drawing.Point(50, 52);
            this.lbl_First.Name = "lbl_First";
            this.lbl_First.Size = new System.Drawing.Size(26, 13);
            this.lbl_First.TabIndex = 4;
            this.lbl_First.Text = "First";
            // 
            // lbl_Last
            // 
            this.lbl_Last.AutoSize = true;
            this.lbl_Last.Location = new System.Drawing.Point(256, 52);
            this.lbl_Last.Name = "lbl_Last";
            this.lbl_Last.Size = new System.Drawing.Size(27, 13);
            this.lbl_Last.TabIndex = 5;
            this.lbl_Last.Text = "Last";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(462, 52);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Title";
            // 
            // newEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(714, 201);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Last);
            this.Controls.Add(this.lbl_First);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txt_Last);
            this.Controls.Add(this.txt_First);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(730, 240);
            this.MinimumSize = new System.Drawing.Size(730, 240);
            this.Name = "newEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_First;
        private System.Windows.Forms.TextBox txt_Last;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_First;
        private System.Windows.Forms.Label lbl_Last;
        private System.Windows.Forms.Label lbl_Title;
    }
}