namespace trees2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lblBG = new Label();
            txtName = new TextBox();
            txtNameBG = new TextBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl1.Location = new Point(142, 55);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(56, 21);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name";
            // 
            // lblBG
            // 
            lblBG.AutoSize = true;
            lblBG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBG.Location = new Point(561, 55);
            lblBG.Name = "lblBG";
            lblBG.Size = new Size(84, 21);
            lblBG.TabIndex = 1;
            lblBG.Text = "Name_BG";
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtNameBG
            // 
            txtNameBG.Location = new Point(547, 103);
            txtNameBG.Name = "txtNameBG";
            txtNameBG.Size = new Size(114, 23);
            txtNameBG.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn1.Location = new Point(219, 295);
            btn1.Name = "btn1";
            btn1.Size = new Size(319, 92);
            btn1.TabIndex = 4;
            btn1.Text = "Insert into type";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(txtNameBG);
            Controls.Add(txtName);
            Controls.Add(lblBG);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Помощни таблици";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblBG;
        private TextBox txtName;
        private TextBox txtNameBG;
        private Button btn1;
    }
}
