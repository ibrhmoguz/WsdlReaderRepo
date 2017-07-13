namespace WsdlReader
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.invokeButton = new System.Windows.Forms.Button();
            this.treeOutput = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeParameters = new System.Windows.Forms.TreeView();
            this.treeWsdl = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WSDL address :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(604, 22);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(685, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 335);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.invokeButton);
            this.tabPage1.Controls.Add(this.treeOutput);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.treeParameters);
            this.tabPage1.Controls.Add(this.treeWsdl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Invoke";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(362, 27);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(208, 193);
            this.propertyGrid1.TabIndex = 33;
            this.propertyGrid1.Validated += new System.EventHandler(this.propertyGrid1_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Methods :";
            // 
            // invokeButton
            // 
            this.invokeButton.Location = new System.Drawing.Point(422, 245);
            this.invokeButton.Name = "invokeButton";
            this.invokeButton.Size = new System.Drawing.Size(75, 23);
            this.invokeButton.TabIndex = 31;
            this.invokeButton.Text = "Invoke";
            this.invokeButton.UseVisualStyleBackColor = true;
            this.invokeButton.Click += new System.EventHandler(this.invokeButton_Click);
            // 
            // treeOutput
            // 
            this.treeOutput.Location = new System.Drawing.Point(576, 27);
            this.treeOutput.Name = "treeOutput";
            this.treeOutput.ShowNodeToolTips = true;
            this.treeOutput.Size = new System.Drawing.Size(153, 270);
            this.treeOutput.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Output :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Parameters :";
            // 
            // treeParameters
            // 
            this.treeParameters.Location = new System.Drawing.Point(178, 27);
            this.treeParameters.Name = "treeParameters";
            this.treeParameters.Size = new System.Drawing.Size(178, 270);
            this.treeParameters.TabIndex = 27;
            this.treeParameters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeParameters_AfterSelect_1);
            // 
            // treeWsdl
            // 
            this.treeWsdl.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.treeWsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeWsdl.ItemHeight = 20;
            this.treeWsdl.Location = new System.Drawing.Point(8, 27);
            this.treeWsdl.Name = "treeWsdl";
            this.treeWsdl.Size = new System.Drawing.Size(164, 270);
            this.treeWsdl.TabIndex = 26;
            this.treeWsdl.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeWsdl_AfterSelect_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.messageTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Message";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 283);
            this.progressBar1.Maximum = 70;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.AllowDrop = true;
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.messageTextBox.Location = new System.Drawing.Point(6, 6);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(725, 274);
            this.messageTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 403);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button invokeButton;
        private System.Windows.Forms.TreeView treeOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeParameters;
        private System.Windows.Forms.TreeView treeWsdl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

