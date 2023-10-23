namespace macOS_VMX_Patcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            browsefile = new Button();
            TextBox = new TextBox();
            patchbtn = new Button();
            DropBox = new ComboBox();
            uninstallbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browsefile
            // 
            browsefile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browsefile.FlatStyle = FlatStyle.System;
            browsefile.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            browsefile.Location = new Point(226, 30);
            browsefile.Name = "browsefile";
            browsefile.Size = new Size(94, 29);
            browsefile.TabIndex = 0;
            browsefile.Text = "Browse";
            browsefile.UseVisualStyleBackColor = true;
            browsefile.Click += browsefile_Click;
            // 
            // TextBox
            // 
            TextBox.BorderStyle = BorderStyle.FixedSingle;
            TextBox.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox.Location = new Point(12, 32);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(205, 27);
            TextBox.TabIndex = 1;
            // 
            // patchbtn
            // 
            patchbtn.FlatStyle = FlatStyle.System;
            patchbtn.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            patchbtn.Location = new Point(3, 3);
            patchbtn.Name = "patchbtn";
            patchbtn.Size = new Size(94, 29);
            patchbtn.TabIndex = 2;
            patchbtn.Text = "Patch";
            patchbtn.UseVisualStyleBackColor = true;
            patchbtn.Click += patchbtn_Click;
            // 
            // DropBox
            // 
            DropBox.FlatStyle = FlatStyle.System;
            DropBox.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(95, 95);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(150, 28);
            DropBox.TabIndex = 3;
            DropBox.Text = "CPU";
            // 
            // uninstallbtn
            // 
            uninstallbtn.Enabled = false;
            uninstallbtn.FlatStyle = FlatStyle.System;
            uninstallbtn.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uninstallbtn.Location = new Point(213, 3);
            uninstallbtn.Name = "uninstallbtn";
            uninstallbtn.Size = new Size(94, 29);
            uninstallbtn.TabIndex = 4;
            uninstallbtn.Text = "Uninstall";
            uninstallbtn.UseVisualStyleBackColor = true;
            uninstallbtn.Click += uninstallbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 20);
            label1.TabIndex = 5;
            label1.Text = "Choose your VMX file location:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 6;
            label2.Text = "Choose your CPU:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(uninstallbtn);
            panel1.Controls.Add(patchbtn);
            panel1.Location = new Point(12, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 95);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 52);
            panel3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(292, 40);
            label4.TabIndex = 0;
            label4.Text = "Please note to keep the VMX Patcher \r\nopen to uninstall the patch.";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 22);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 20);
            label3.TabIndex = 0;
            label3.Text = "VMware macOS VMX Patcher v1.0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 253);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DropBox);
            Controls.Add(TextBox);
            Controls.Add(browsefile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "VMX Patcher";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button browsefile;
        private TextBox TextBox;
        private Button patchbtn;
        private ComboBox DropBox;
        private Button uninstallbtn;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
    }
}