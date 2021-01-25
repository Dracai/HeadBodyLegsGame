
namespace HeadBodyLegsGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.cckAnimals = new System.Windows.Forms.CheckBox();
            this.cckMythical = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtLegs = new System.Windows.Forms.TextBox();
            this.btnGenHead = new System.Windows.Forms.Button();
            this.btnGenBody = new System.Windows.Forms.Button();
            this.btnGenLegs = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Head Body Legs !";
            // 
            // cckAnimals
            // 
            this.cckAnimals.AutoSize = true;
            this.cckAnimals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cckAnimals.Location = new System.Drawing.Point(74, 116);
            this.cckAnimals.Name = "cckAnimals";
            this.cckAnimals.Size = new System.Drawing.Size(85, 25);
            this.cckAnimals.TabIndex = 1;
            this.cckAnimals.Text = "Animals";
            this.cckAnimals.UseVisualStyleBackColor = true;
            this.cckAnimals.CheckedChanged += new System.EventHandler(this.cckAnimals_CheckedChanged);
            // 
            // cckMythical
            // 
            this.cckMythical.AutoSize = true;
            this.cckMythical.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cckMythical.Location = new System.Drawing.Point(322, 116);
            this.cckMythical.Name = "cckMythical";
            this.cckMythical.Size = new System.Drawing.Size(159, 25);
            this.cckMythical.TabIndex = 2;
            this.cckMythical.Text = "Mythical Creatures";
            this.cckMythical.UseVisualStyleBackColor = true;
            this.cckMythical.CheckedChanged += new System.EventHandler(this.cckMythical_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(172, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pick your categories :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Head :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(115, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Body :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(118, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Legs :";
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(173, 288);
            this.txtHead.Name = "txtHead";
            this.txtHead.ReadOnly = true;
            this.txtHead.Size = new System.Drawing.Size(148, 23);
            this.txtHead.TabIndex = 8;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(173, 358);
            this.txtBody.Name = "txtBody";
            this.txtBody.ReadOnly = true;
            this.txtBody.Size = new System.Drawing.Size(148, 23);
            this.txtBody.TabIndex = 9;
            // 
            // txtLegs
            // 
            this.txtLegs.Location = new System.Drawing.Point(173, 433);
            this.txtLegs.Name = "txtLegs";
            this.txtLegs.ReadOnly = true;
            this.txtLegs.Size = new System.Drawing.Size(148, 23);
            this.txtLegs.TabIndex = 10;
            // 
            // btnGenHead
            // 
            this.btnGenHead.Location = new System.Drawing.Point(338, 285);
            this.btnGenHead.Name = "btnGenHead";
            this.btnGenHead.Size = new System.Drawing.Size(93, 34);
            this.btnGenHead.TabIndex = 11;
            this.btnGenHead.Text = "Generate Head";
            this.btnGenHead.UseVisualStyleBackColor = true;
            this.btnGenHead.Click += new System.EventHandler(this.btnGenHead_Click);
            // 
            // btnGenBody
            // 
            this.btnGenBody.Location = new System.Drawing.Point(338, 355);
            this.btnGenBody.Name = "btnGenBody";
            this.btnGenBody.Size = new System.Drawing.Size(93, 34);
            this.btnGenBody.TabIndex = 12;
            this.btnGenBody.Text = "Generate Body";
            this.btnGenBody.UseVisualStyleBackColor = true;
            this.btnGenBody.Click += new System.EventHandler(this.btnGenBody_Click);
            // 
            // btnGenLegs
            // 
            this.btnGenLegs.Location = new System.Drawing.Point(338, 426);
            this.btnGenLegs.Name = "btnGenLegs";
            this.btnGenLegs.Size = new System.Drawing.Size(93, 34);
            this.btnGenLegs.TabIndex = 13;
            this.btnGenLegs.Text = "Generate Legs";
            this.btnGenLegs.UseVisualStyleBackColor = true;
            this.btnGenLegs.Click += new System.EventHandler(this.btnGenLegs_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 43);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 43);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(254)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(554, 593);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenLegs);
            this.Controls.Add(this.btnGenBody);
            this.Controls.Add(this.btnGenHead);
            this.Controls.Add(this.txtLegs);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cckMythical);
            this.Controls.Add(this.cckAnimals);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Head Body Legs Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cckAnimals;
        private System.Windows.Forms.CheckBox cckMythical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtLegs;
        private System.Windows.Forms.Button btnGenHead;
        private System.Windows.Forms.Button btnGenBody;
        private System.Windows.Forms.Button btnGenLegs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

